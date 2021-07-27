var promise1 = new Promise(function (resolve, reject) {
    setTimeout(function () {
        resolve("a result from the promise");
    }, 5000);
});

promise1.then(function (value) {
    console.log("result: " + value);
});

console.log(promise1);