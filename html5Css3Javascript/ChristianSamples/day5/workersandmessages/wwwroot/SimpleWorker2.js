let i = 0;

function timedCount() {
  i++;
  postMessage(i);
  setTimeout(timedCount, 1000);

  if (i >= 20)
  {
    close();
  }
}

timedCount();