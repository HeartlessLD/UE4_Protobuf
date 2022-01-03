// Fill out your copyright notice in the Description page of Project Settings.


#include "MyActor.h"

#include "test.pb.h"
// Sets default values
AMyActor::AMyActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
	
	
	//GEngine->AddOnScreenDebugMessage(-1, 5.f, FColor::Red, FString::FromInt(a.page_number()));
}

// Called when the game starts or when spawned
void AMyActor::BeginPlay()
{
	Super::BeginPlay();
	SearchRequest a;
	a.set_page_number(199);
	GEngine->AddOnScreenDebugMessage(-1, 5.f, FColor::Red, FString::FromInt(a.page_number()));
}

// Called every frame
void AMyActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}
