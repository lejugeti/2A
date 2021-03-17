import { StatusBar } from 'expo-status-bar';
import React, {useState} from 'react';
import { StyleSheet, Text, View, TextInput, Image, TouchableOpacity, Alert } from 'react-native';

export default function App() {

  const[email, setEmail] = useState('');
  const[password, setPassword] = useState('');

  const alertInscription = () =>{
    Alert.alert(
      'Action demandée',
      'Inscription',
      [{text: 'OK'}]
    )
  }

  const alertConnexion = () =>{
    const message = `Email : ${email} \nMDP : ${password}`;
    Alert.alert(
      'Action demandée',
      message,
      [{text: 'OK'}]
    )
  }

  const alertChangeMdp = () =>{
    Alert.alert(
      'Action demandée',
      'Changement de mot de passe',
      [{text: 'OK'}]
    )
  }
  

  return (
    <View style={styles.container}>

      <Image style={styles.logo} source={require('./assets/cat.jpg')}/>
      
      <View style={styles.inputGroup}>
        <Image 
          style={[styles.inputLogo, styles.inputComponents]}
          source={require('./assets/mail.png')}
          />
        <TextInput 
          style={[styles.input, styles.inputComponents]} 
          placeholder={'Email'}
          onChangeText={text => setEmail(text)}
        />
      </View>

      <View style={styles.inputGroup}>
        <Image 
          style={[styles.inputLogo, styles.inputComponents]}
          source={require('./assets/key.png')}
          />
        <TextInput 
          style={[styles.input, styles.inputComponents]} 
          placeholder={'Mot de passe'}
          onChangeText={text => setPassword(text)}
          />
      </View>

      <TouchableOpacity onPress={alertConnexion} style={styles.btn}>
        <View >
          <Text style={{color: 'white'}}>Se connecter</Text>
        </View>
      </TouchableOpacity>

      <TouchableOpacity onPress={alertChangeMdp} style={styles.link}>
        <View>
          <Text>Mot de passe oublié ?</Text>
        </View>
      </TouchableOpacity>

      <TouchableOpacity onPress={alertInscription} style={styles.link}>
        <View>
          <Text>S'inscrire</Text>
        </View>
      </TouchableOpacity>

      
      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  inputGroup:{
    flex: 0.15,
    flexDirection: 'row',
    alignItems: 'center',
    width: 200,
    borderRadius: 30,
    borderWidth: 2,
    borderColor: 'gray',
    margin: 10
  },
  input:{
    flex: 4,
  },
  inputLogo:{
    flex: 1,
    height: 30,
    width: 30
  },
  logo:{
    height: 100,
    width: 100
  },
  inputComponents:{
    margin: 10
  },
  btn: {
    flex: 0.1,
    width:200,
    justifyContent:'center',
    alignItems: 'center',
    backgroundColor: 'skyblue',
    borderRadius: 30,
    margin:10
  },
  link: {
    flex: 0.1,
    width:200,
    justifyContent:'center',
    alignItems: 'center',
    color: 'black'
  }
});
