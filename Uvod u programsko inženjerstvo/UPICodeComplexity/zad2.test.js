const faktorijel = require('./zad2.js');

test("5! equals 120", () => {
  expect(faktorijel(5)).toEqual(120);
});

test("3! equals 6", () => {
    expect(faktorijel(3)).toEqual(6);
  });

test("0! equals 1", () => {
    expect(faktorijel(0)).toEqual(1);
});




