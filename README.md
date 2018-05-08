# fluent Api Tutorial
Using a base interface of IBodmas, create a fluent syntax which would allow me to do the following:
   
   
  <code>var formula = 4.Add(3.Brackets(2.Multiply(5))).Div(6);</code>
  </br>
  <code> var result = Bodmas.Execute(formula); // 9</code>


The fluent interfaces should ensure that I can't create a malformed formula and the implementation should expand the formula to calculate
the result honoring the order of execution as demonstrated here: https://www.mathsisfun.com/algebra/operations-order-calculator.html
We also try to achive the following result too:

  <code>var formula = 4.Add(3.Brackets(2.Multiply(5))).Div(6);</code>
  </br>
  <code>var result = Bodmas.ToString(formula); // "4 + 3(2 * 5) / 6"</code>

