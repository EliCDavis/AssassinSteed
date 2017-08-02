## Coding Guidelines

Example:

```c#
// file under Scripts/Prototyping/Movement
namespace AssassinSteed.Prototyping.Movement
{
    
    /// <summary>
    /// Document Everything
    /// </summary>
    class ClassName()
    {
    
        // All private/protected variables, camel case
        private int variableOne;

        /// <summary>
        /// returns foo or something
        /// </summary>
        public int GetFoo()
        {
            // All temporary variables begin with _
            int _temp = 5;
            return this.variableOne;
        }

    }

}

```