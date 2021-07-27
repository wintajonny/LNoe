document.addEventListener("DOMContentLoaded", function() {
  const module = {
    x: 42,
    getX: function() {
        return this.x;
    }
  };
  
  function foo(a, b, c)
  {
    console.log('a: ' + a);
    console.log('b: ' + b);
    console.log('c: ' + c);
  }
  
  const a = module.getX;
  console.log(a());
  
  const b = module.getX.bind(module);
  console.log(b());
  
  const foobound = foo.bind(null, 1, 2);
  
  foobound(3);
});

