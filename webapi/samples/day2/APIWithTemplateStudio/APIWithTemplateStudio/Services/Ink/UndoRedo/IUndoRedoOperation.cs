namespace APIWithTemplateStudio.Services.Ink.UndoRedo
{
    public interface IUndoRedoOperation
    {
        void ExecuteUndo();

        void ExecuteRedo();
    }
}
