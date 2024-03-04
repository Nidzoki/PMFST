slika = imread("C:\Users\nikol\Downloads\zoo-8378189_640.jpg");

siva = rgb2gray(slika);

hsv_slika = rgb2hsv(slika);

[H, S, V] = imsplit(hsv_slika);


subplot(1,3,1);
imcontour(H);
subplot(1,3,2);
imcontour(S);
subplot(1,3,3);
imcontour(V);