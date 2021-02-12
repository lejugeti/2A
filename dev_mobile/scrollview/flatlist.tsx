import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { FlatList, ScrollView, StyleSheet, Text, View } from 'react-native';

interface Person{
  id: number,
  text: string
};

const DATA = [
  {id: 1, text: 'JMA'},
  {id: 2, text: 'bpesquet'},
  {id: 3, text: 'bernard'},
  {id: 4, text: 'salotti'},
  {id: 5, text: 'edwige'},
  {id: 6, text: 'rocco'}
];

const Item = ({text}:{text:string}) =>(
  <View style={styles.nom}>
    <Text>{text}</Text>
  </View>
);

export default function App() {
  
  const renderItem=({item}:{item:Person})=>(
    <Item text={item.text}/>
  );

  return (
    <View style={styles.container}>
      <FlatList
        data={DATA}
        renderItem={renderItem}
        keyExtractor={item=>item.text}
      />
      
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'stretch',
    justifyContent: 'center',
  },
  nom: {
    height: 50,
    backgroundColor: 'skyblue',
    borderWidth: 3
  }
});
