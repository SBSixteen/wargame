
using wargame;

Human A = new Human("Marcus Gaius", "An ordinary rifleman", "Human", Constants.skeleton[0]);
ArmorPlatform simplePlateCarrier = new ArmorPlatform("MSTA", "A simple torso plate carrier", "ArmorPlatform", Constants.skeleton[3], 2);
ArmorPlate plate = new ArmorPlate("C-1", "A regular ceramic armor plate", "ArmorPlate", Constants.skeleton[2], 8.0f);

simplePlateCarrier.addPlate(plate);
simplePlateCarrier.addPlate(plate);
A.assignChildren(simplePlateCarrier);

A.print();

Constants.revealHistory();