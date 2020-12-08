//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PlayerDependencyComponent playerDependency { get { return (PlayerDependencyComponent)GetComponent(GameComponentsLookup.PlayerDependency); } }
    public bool hasPlayerDependency { get { return HasComponent(GameComponentsLookup.PlayerDependency); } }

    public void AddPlayerDependency(int newValue) {
        var index = GameComponentsLookup.PlayerDependency;
        var component = (PlayerDependencyComponent)CreateComponent(index, typeof(PlayerDependencyComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePlayerDependency(int newValue) {
        var index = GameComponentsLookup.PlayerDependency;
        var component = (PlayerDependencyComponent)CreateComponent(index, typeof(PlayerDependencyComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerDependency() {
        RemoveComponent(GameComponentsLookup.PlayerDependency);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlayerDependency;

    public static Entitas.IMatcher<GameEntity> PlayerDependency {
        get {
            if (_matcherPlayerDependency == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerDependency);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerDependency = matcher;
            }

            return _matcherPlayerDependency;
        }
    }
}