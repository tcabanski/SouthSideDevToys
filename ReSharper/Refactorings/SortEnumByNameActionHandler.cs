using System;
using System.Collections.Generic;
using JetBrains.ActionManagement;
using JetBrains.Application;
using JetBrains.IDE;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.TextControl;
using JetBrains.Util;

namespace SouthSideSharper.Refactorings {
    [ActionHandler("SouthSideSharper.SortEnumByName")]
    public class SortEnumByNameActionHandler : ActionHandlerBase {
        #region Protected methods

        /// <summary>
        /// Executes action. Called after Update, that set <c>ActionPresentation.Enabled</c> to true.
        /// </summary>
        /// <param name="solution">The solution.</param>
        /// <param name="context">The context.</param>
        protected override void Execute(ISolution solution, IDataContext context) {
            if (!context.CheckAllNotNull(DataConstants.SOLUTION)) {
                return;
            }

            ITextControl textControl = context.GetData(DataConstants.TEXT_CONTROL);
            if (textControl == null) {
                return;
            }

            IElement element = GetElementAtCaret(context);
            if (element == null) {
                return;
            }

            var enumDeclaration = element.ToTreeNode().Parent as IEnumDeclaration;
            if (enumDeclaration == null) {
                return;
            }

            using (ModificationCookie cookie = textControl.Document.EnsureWritable()) {
                if (cookie.EnsureWritableResult != EnsureWritableResult.SUCCESS) {
                    return;
                }

                using (CommandCookie.Create("Context Action Sort Enum By Name")) {
                    PsiManager.GetInstance(solution).DoTransaction(delegate { Execute(solution, enumDeclaration); });
                }
            }
        }

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns><c>true</c>, if updateable.</returns>
        protected override bool Update(IDataContext context) {
            if (!context.CheckAllNotNull(DataConstants.SOLUTION)) {
                return false;
            }

            IElement element = GetElementAtCaret(context);
            if (element == null) {
                return false;
            }

            var enumDeclaration = element.ToTreeNode().Parent as IEnumDeclaration;
            if (enumDeclaration == null) {
                return false;
            }

            return true;
        }

        #endregion

        #region Private methods

        private static void Execute(ISolution solution, IEnumDeclaration enumDeclaration) {
            CSharpElementFactory factory = CSharpElementFactory.GetInstance(enumDeclaration.GetPsiModule());
            if (factory == null) {
                return;
            }

            SortEnumMembers(solution, enumDeclaration, factory);
        }

        private static void SortEnumMembers(ISolution solution, IEnumDeclaration enumDeclaration,
                                            CSharpElementFactory factory) {
            try {
                var enumMembers = new SortedDictionary<string, IEnumMemberDeclaration>();
                foreach (IEnumMemberDeclaration enumMember in enumDeclaration.EnumMemberDeclarations) {
                    enumMembers.Add(enumMember.DeclaredName, enumMember);
                }
                IEnumMemberDeclaration firstEnumMember = null;
                foreach (IEnumMemberDeclaration enumMember in enumMembers.Values) {
                    firstEnumMember = enumMember;
                    break;
                }
                foreach (IEnumMemberDeclaration enumMember in enumMembers.Values) {
                    if (enumMember != firstEnumMember) {
                        enumDeclaration.RemoveEnumMemberDeclaration(enumMember);
                    }
                }
                IEnumMemberDeclaration lastEnumMember = enumDeclaration.EnumMemberDeclarations[0];
                foreach (IEnumMemberDeclaration enumMember in enumMembers.Values) {
                    if (enumMember != firstEnumMember) {
                        IEnumMemberDeclaration newMember = factory.CreateEnumMemberDeclaration(enumMember.DeclaredName);
                        newMember.SetValueExpression(enumMember.ValueExpression);
                        lastEnumMember = enumDeclaration.AddEnumMemberDeclarationAfter(newMember, lastEnumMember);
                    }
                }
            }
            catch (Exception err) {
                Exception e = err;
            }
        }

        #endregion
    }
}