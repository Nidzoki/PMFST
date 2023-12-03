const guessValue = require('./zad1.js');

test('1 equals \"one\"', () => {
  expect(guessValue(1)).toEqual('one');
});

test('2 equals \"two\"', () => {
    expect(guessValue(2)).toEqual('two');
});

test('3 equals \"three\"', () => {
    expect(guessValue(3)).toEqual('three');
});

test('4 equals \"four\"', () => {
    expect(guessValue(4)).toEqual('four');
});

test('8 equals \"Mission failed, we\'ll get them next time!\"', () => {
    expect(guessValue(8)).toEqual("Mission failed, we'll get them next time!");
});