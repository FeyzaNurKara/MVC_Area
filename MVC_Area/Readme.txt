
## AREA
# Muhasebe 
	# Order
	# OrderDetails
	# SalesByCategory
# InsanKaynaklari
	# Employee
# SatinAlma
	# Product
	# Category
	# Supplier
# Admin
	# bütün entitylerin yönetiminden sorumlu.


# MVC projesi
# DbFirst ile Northwin veritbanı'nın yansıması alındı.
# Northwind Context Dependency injection olarak Program.cs içerisinde builder.Services'a dahil edilecek. ConnectionString bilgisi appsettings.json içerisine alınacak.
# Ziyaretçi sayfa tasarımı, Muhasebe sayfa tasarımı, İnsanKaynakları sayfa tasarımı, Satın alma sayfa tasarımı
# Repository ve Service Pattern
	# Repositories klasör içerisinde aşağıdaki interface'ler oluşturulacak.
		# Abstracts
			# IProductRepository
				- GetProductCountAsync();
			# ICategoryRepository
			# ISupplierRepository

		# Concretes
			# ProductRepository
				- GetProductCountAsync();
			# CategoryRepository
			# SupplierRepository

		# Generic Repository oluşturma mantığını daha sonra yapılandıracağız.


# Identity (Kimlik Yönetimi)
# Sepet işlemi