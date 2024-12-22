using System;
using System.Reflection;
using System.Reflection.Emit;
using SaborCubano.Domain;
using SaborCubano.Domain.Commons;

namespace SaborCubano.Application.Commons;

public class GenericDTO<TModel> : IModel where TModel : class, IModel
{
    public GenericDTO(){
        MakeAllPropertyNull();
    }

    public void MakeAllPropertyNull(){
        foreach (PropertyInfo property in GetType().GetProperties())
        {
            property.SetValue(this, null);
        }
    }

    public void CopyPropertyModel(){
        Type dtoType = typeof(GenericDTO<TModel>);
        foreach (PropertyInfo property in typeof(TModel).GetProperties()){

        }
    }

    private void BuildProperty (TypeBuilder typeBuilder, PropertyInfo modelProperty){
        FieldBuilder fieldBuilder = typeBuilder.DefineField(modelProperty.Name, modelProperty.PropertyType,FieldAttributes.Public);

        PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(modelProperty.Name, PropertyAttributes.HasDefault, modelProperty.PropertyType, null);

        MethodBuilder getMethodBuilder = typeBuilder.DefineMethod("get " + modelProperty.Name, MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, modelProperty.PropertyType, Type.EmptyTypes);
        ILGenerator getIl = getMethodBuilder.GetILGenerator();
        getIl.Emit(OpCodes.Ldarg_0);
        getIl.Emit(OpCodes.Ldfld, fieldBuilder); 
        getIl.Emit(OpCodes.Ret); 
        MethodBuilder setMethodBuilder = typeBuilder.DefineMethod("set " + modelProperty.Name, MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, null, new Type[] { modelProperty.PropertyType });
        ILGenerator setIl = setMethodBuilder.GetILGenerator(); 
        setIl.Emit(OpCodes.Ldarg_0); setIl.Emit(OpCodes.Ldarg_1); 
        setIl.Emit(OpCodes.Stfld, fieldBuilder); setIl.Emit(OpCodes.Ret); 
        
        propertyBuilder.SetGetMethod(getMethodBuilder); 
        propertyBuilder.SetSetMethod(setMethodBuilder);
    }
}
