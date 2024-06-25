BaseEntity classi yaradiram daxilinde yalniz Id saxlayiram ve bunu abstract edirem cunki yalniz user, product ve category miras alacaq ve user bunun instance yaratmamalidi. User classinda Role
properties yaratdim. Cunki admin, seller ve chiefcashier elave propertiesi yoxdu buna gorede entity class yaratmaga ehtiyac yoxdu. Admin ve Chief CRUD ve Gets methodlarini islede bilir lakin
seller yalniz gets methodlarini islede bilir buna gore de IReadOnly 
