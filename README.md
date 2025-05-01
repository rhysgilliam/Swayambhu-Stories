# Swayambhu Stories: Unity Model

Welcome to the official repository for the **Swayambhu Stories Website: Unity Model**. This repository hosts the most up-to-date version of the Swayambhu Stories project 3D Unity model for integration with the companion landing page, viewable [here](https://github.com/Fletch235/Swayambhu-Stories-Unity).

---

## Table of Contents
- [Overview](#overview)
- [Setup Instructions](#setup-instructions)
- [Workspace](#Workspace)
- [Annotations](#Annotations)
- [License](#license)

---

## Overview

This repository hosts the 3D Unity model location for the ongoing Swayambhu Stories project. For more information on the overall project, please visit the [landing page website](https://swayambhu-stories-unity-sp25-fstu.apps.cloudapps.unc.edu/). The landing page repository is viewable [here](https://github.com/Fletch235/Swayambhu-Stories-Unity).

## Setup Instructions

To view the Unity model locally in the Unity app, download the version of [Unity Hub](https://unity.com/download) compatible with your computer and clone this repository. You can load in the project in Unity Hub by clicking Add->Add project from disk. This model requires Unity version 6000.0.36f1.

<img width="276" alt="Screenshot 2025-04-30 at 10 12 38 PM" src="https://github.com/user-attachments/assets/5df1c8fa-f8a8-478f-b355-609b1a4cf631" />

Click on the Swayambhu-Stories project pop-up in the Unity to load the model editor. 

<img width="895" alt="Screenshot 2025-04-30 at 10 15 38 PM" src="https://github.com/user-attachments/assets/a437aeb1-c49c-49e7-9645-dfd9353dd7ef" />

## Workspace

Opening the project will open the Unity editor. 

<img width="1440" alt="Screenshot 2025-04-30 at 10 18 06 PM" src="https://github.com/user-attachments/assets/24007c61-708c-4666-a293-b10a793c538e" />

This 3D model comes with a FirstPersonController object for the user to explore the site. All scripts used for interactivity are hosted in Assets --> Scripts. All colliders are 

<img width="201" alt="Screenshot 2025-04-30 at 10 17 38 PM" src="https://github.com/user-attachments/assets/c825006a-192c-4fff-a844-eed6bae501b9" />

## Annotations

Sample annotations are added into this project. To add video or text annotations, use the following steps:

### Text Annotation

Copy-paste one of the example text annotations, such as 'Anantapura (#12)' in the Main Scene editor. This will clone the entire text-interactive annotation object, including the lotus flower interactive object, text canvas, and attached scripts. Use the movement arrows to place this object to where desired in the model overworld.

<div align="center">
  <img width="178" alt="Screenshot 2025-04-30 at 10 23 06 PM" src="https://github.com/user-attachments/assets/5a4bda27-1f8f-43ee-85e9-981937852c1d" />
  <img width="186" alt="Screenshot 2025-04-30 at 10 23 30 PM" src="https://github.com/user-attachments/assets/519ae627-a9ed-4c25-a425-5d6c1eb2f2eb" />
  <img width="1440" alt="Screenshot 2025-04-30 at 10 27 05 PM" src="https://github.com/user-attachments/assets/ebef76cb-6b86-4665-ab3f-665f978d2345" />
</div>

The annotations script automatically hides the text annotation canvas from the player, and will only show it on input once the user approaches the annotations object. To add a text canvas that will pop-up when the viewer gets close to this example, annotation, copy-paste one of the example objects that are prefaced with 'TEXT', such as 'TEXT - Anantapura (#12)'. 

<div align="center">
  <img width="190" alt="Screenshot 2025-04-30 at 10 29 33 PM" src="https://github.com/user-attachments/assets/4b16a5d8-3924-421e-8f8c-898ad56cc1e2" />
  <img width="206" alt="Screenshot 2025-04-30 at 10 30 01 PM" src="https://github.com/user-attachments/assets/0b980a0f-5fdf-41b6-ae87-cf6ee7ba694c" />
</div>

The object is by default hidden from user view. To see it, check the box next to the annotation name in the top-right Inspector window.

<div align="center"> 
    <img width="365" alt="Screenshot 2025-04-30 at 10 31 12 PM" src="https://github.com/user-attachments/assets/56c44d2b-ca63-4946-b0a8-719e5cacea02" />
</div>

.fbx model is too large for the Github repo, so need to add it in manually. Add the .fbx file to Assets/OversizedFiles and in the Unity editor, load in "SampleScene" to see the model. If a prefab error happens press on the Object prompt and enter in "12.5MillionTriangles" model.

Importing videos using external URL have to follow a specific link type. delete the 'dl=0' and replace with 'raw=1' if using DropBox.
