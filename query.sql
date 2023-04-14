
-- create

CREATE TABLE tblProducts (
  prodId INTEGER PRIMARY KEY AUTO_INCREMENT,
  prodName TEXT NOT NULL
);

CREATE TABLE tblCategories (
  catId INTEGER PRIMARY KEY AUTO_INCREMENT,
  catName TEXT NOT NULL
);

CREATE TABLE tblProductCategories (
  prodId INTEGER NOT NULL,
  catId INTEGER NOT NULL,
  FOREIGN KEY (prodId) REFERENCES tblProducts (prodId),
  FOREIGN KEY (catId) REFERENCES tblCategories (catId),
	PRIMARY KEY (prodId, catId)
);

-- insert

INSERT INTO tblProducts(prodName) 
VALUES 
  ('prod1'),
  ('prod2'),
  ('prod3'),
  ('prod4'),
  ('prod5');

INSERT INTO tblCategories(catName) 
VALUES 
  ('cat1'),
  ('cat2'),
  ('cat3'),
  ('cat4'),
  ('cat5');

INSERT INTO tblProductCategories 
VALUES 
  (1, 1),
  (1, 2),
  (2, 3),
  (3, 3),
  (4, 5);

-- procedure

DELIMITER //

DROP PROCEDURE IF EXISTS showProductsCategories //

CREATE PROCEDURE myProcedure()
BEGIN  
  SELECT tblProducts.prodName, tblCategories.catName
  FROM tblProducts
  LEFT JOIN tblProductCategories
  	ON tblProducts.prodId = tblProductCategories.prodId
  LEFT JOIN tblCategories
  	ON tblProductCategories.catId = tblCategories.catId;
END 
//

DELIMITER ;

-- fetch 

CALL myProcedure();
