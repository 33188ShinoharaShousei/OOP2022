// �o�C�g�z���Image�I�u�W�F�N�g�ɕϊ�
public static Image ByteArrayToImage(byte[] b) {
    ImageConverter imgconv = new ImageConverter();
    Image img = (Image)imgconv.ConvertFrom(b);
    return img;
}

// Image�I�u�W�F�N�g���o�C�g�z��ɕϊ�
public static byte[] ImageToByteArray(Image img) {
    ImageConverter imgconv = new ImageConverter();
    byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
    return b;
}
