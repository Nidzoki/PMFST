const povrsinaTrokuta = require('./zad3.js');

test("1, 1, 1 equals 0.43", () => {
  expect(povrsinaTrokuta(1, 1, 1)).toEqual("0.43");
});

test("1, 2, 4 equals \"Trokut ne postoji!\"", () => {
  expect(povrsinaTrokuta(1, 2, 4)).toEqual("Trokut ne postoji!");
});

test("1, 2, 3 equals 0", () => {
  expect(povrsinaTrokuta(1, 2, 3)).toEqual("0.00");
});