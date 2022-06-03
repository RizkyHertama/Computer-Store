CREATE DATABASE CompStore

CREATE TABLE Produk (
	IDProduk int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NamaProduk	VARCHAR	(30) NOT NULL,
	KategoriProduk	VARCHAR	(30) NOT NULL,
	MerkProduk	VARCHAR	(30) NOT NULL,
	StockProduk INT NOT NULL,
	HargaProduk DECIMAL NOT NULL
);

CREATE TABLE Customer (
	IDCustomer int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NamaCustomer	VARCHAR	(30) NOT NULL,
	AlamatCustomer	VARCHAR	(30),
	Telepon	VARCHAR	(15),
);

CREATE TABLE Staff (
	IDStaff int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NamaStaff	VARCHAR	(30) NOT NULL,
	AlamatStaff	VARCHAR	(30) NOT NULL,
	JabatanStaff	VARCHAR	(30) NOT NULL,
	Telepon	VARCHAR	(15) NOT NULL,
);

CREATE TABLE Supplier (
	IDSupplier int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NamaSupplier	VARCHAR	(30) NOT NULL,
	AlamatSupplier	VARCHAR	(30) NOT NULL,
	Telepon	VARCHAR	(15) NOT NULL,
);

CREATE TABLE PembelianBarang (
	IDPembelian INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDproduk INT NOT NULL,
	JumlahBarang INT NOT NULL,
	HargaProduk DECIMAL NOT NULL,
	TanggalPembelian DATE NOT NULL,
	IDSupplier INT NOT NULL,
	IDStaff INT NOT NULL,
	IDPembayaran INT NOT NULL,
	FOREIGN KEY (IDPembayaran) REFERENCES Pembayaran(IDPembayaran),
	FOREIGN KEY (IDProduk) REFERENCES Produk(IDProduk),
	FOREIGN KEY (IDSupplier) REFERENCES Supplier(IDSupplier),
	FOREIGN KEY (IDStaff) REFERENCES Staff(IDStaff)
);

CREATE TABLE PenjualanBarang (
	IDPenjualan INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDproduk INT NOT NULL,
	JumlahBarang INT NOT NULL,
	HargaProduk DECIMAL NOT NULL,
	TanggalPembelian DATE NOT NULL,
	IDCustomer INT NOT NULL,
	IDStaff INT NOT NULL,
	IDPembayaran INT NOT NULL,
	FOREIGN KEY (IDPembayaran) REFERENCES Pembayaran(IDPembayaran),
	FOREIGN KEY (IDProduk) REFERENCES Produk(IDProduk),
	FOREIGN KEY (IDCustomer) REFERENCES Customer(IDCustomer),
	FOREIGN KEY (IDStaff) REFERENCES Staff(IDStaff)
);

CREATE TABLE Pembayaran(
	IDPembayaran INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	JenisPembayaran	VARCHAR	(30) NOT NULL
);