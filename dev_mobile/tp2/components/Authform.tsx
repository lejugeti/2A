import React, {Component} from 'react';
import { StyleSheet, Text, View, TextInput, Image, TouchableOpacity, Alert } from 'react-native';

class Authform extends Component{
    
    state = {email: '', password: ''};

    alertInscription = () =>{
        Alert.alert(
        'Action demandée',
        'Inscription',
        [{text: 'OK'}]
        )
    }

    alertConnexion = () =>{
        const message = `Email : ${this.state.email} \nMDP : ${this.state.password}`;
        Alert.alert(
        'Action demandée',
        message,
        [{text: 'OK'}]
        )
    }

    alertChangeMdp = () =>{
        Alert.alert(
        'Action demandée',
        'Changement de mot de passe',
        [{text: 'OK'}]
        )
    }

    render(){
        return (
            <View>
                <Image style={styles.logo} source={require('../assets/cat.jpg')}/>
      
                <View style={styles.inputGroup}>
                    <Image 
                    style={[styles.inputLogo, styles.inputComponents]}
                    source={require('../assets/mail.png')}
                    />
                    <TextInput 
                    style={[styles.input, styles.inputComponents]} 
                    placeholder={'Email'}
                    onChangeText={text => this.state.email=text}
                    />
                </View>

                <View style={styles.inputGroup}>
                    <Image 
                    style={[styles.inputLogo, styles.inputComponents]}
                    source={require('../assets/key.png')}
                    />
                    <TextInput 
                    style={[styles.input, styles.inputComponents]} 
                    placeholder={'Mot de passe'}
                    onChangeText={text => this.state.password=text}
                    />
                </View>

                <TouchableOpacity onPress={this.alertConnexion} style={styles.btn}>
                    <View >
                    <Text style={{color: 'white'}}>Se connecter</Text>
                    </View>
                </TouchableOpacity>

                <TouchableOpacity onPress={this.alertChangeMdp} style={styles.link}>
                    <View>
                    <Text>Mot de passe oublié ?</Text>
                    </View>
                </TouchableOpacity>

                <TouchableOpacity onPress={this.alertInscription} style={styles.link}>
                    <View>
                    <Text>S'inscrire</Text>
                    </View>
                </TouchableOpacity>
            </View>
        )
    }

    
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
  
export default Authform;