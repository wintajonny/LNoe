using System;



namespace AnnotationsSample
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    sealed class MySampleAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        // This is a positional argument
        public MySampleAttribute(string positionalString)
        {
            this.positionalString = positionalString;
        }

        public void SomeAction()
        {
            Console.WriteLine("Some action");
        }

        public string PositionalString => positionalString;

        // This is a named argument
        public int NamedInt { get; set; }
    }

}
