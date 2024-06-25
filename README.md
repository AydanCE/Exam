BaseEntity classi yaradiram daxilinde yalniz Id saxlayiram ve bunu abstract edirem cunki yalniz user, product ve category miras alacaq ve user bunun instance yaratmamalidi. User classinda Role
properties yaratdim. Cunki admin, seller ve chiefcashier elave propertiesi yoxdu buna gorede entity class yaratmaga ehtiyac yoxdu. Admin ve Chief CRUD ve Gets methodlarini islede bilir lakin
seller yalniz gets methodlarini islede bilir buna gore de IReadOnly interface yaradiram ve Get methodlarinin imzasini saxlayiram. IProductManager
interface yaratdim ve bu IReadOnly den miras aldi cunki CRUD operationlarini ede bilenler get methodlarinida ede biler. Lakin Admin ve Chief eyni
methodlari isledir buna gore kod tekrari olacaq buna gore de abstract ProductManager classi yaradiram ve IProductManager den miras alir
abstract classda implementation edirem ve adminmanager ve chiefmanager ProductManagerden miras alir ve tekrar olmur. Lakin Admin ve Chief elave
methodlari var lakin gelecekde bunlari basqa classlarda islede biler deye IAdminManager ve IChiefManager interface yaradiram ve Admin ve Chief manager
classlari bunlardan miras alir ve daxilinde implementation olunur. 
