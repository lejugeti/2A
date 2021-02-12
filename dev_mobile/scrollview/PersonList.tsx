import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { FlatList, ScrollView, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';

interface Person{
  id: number,
  prenom: string,
  nom: string
};

const DATA: Array<Person> = [
  {id: 1, prenom: 'bjr', nom:'yo'},
  {id: 2, prenom: 'antoine', nom:'parize'},
  {id: 3, prenom: 'juliette', nom:'esquirol'}
];

const Item = ({person}:{person:Person}) =>(
  <View>
    <Text style={styles.person}>{person.prenom} {person.nom.toUpperCase()}</Text>
  </View>
);

const renderItem = ({item}:{item:Person}) =>(
  <Item person={item}></Item>
);

const PersonList = ({people}: {people: Array<Person>}) => (
  
  <FlatList
    data={people}
    renderItem={renderItem}
    keyExtractor={item=>item.id.toString()}
    >
  </FlatList>
);

export default function App() {

  

  return (
    <View style={styles.container}>
      <PersonList people={DATA}></PersonList>
      
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    marginTop: 40,
    backgroundColor: '#fff',
    alignItems: 'stretch',
    justifyContent: 'center',
  },
  person: {
    flex: 1,
    margin: 5,
    fontSize: 20,
    borderWidth: 2,
    backgroundColor: 'skyblue'
  }
});
