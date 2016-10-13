# log4net.ForegroundPropagationAppender

Propagation log message to Window Form.

### log4net Config
```xml
<log4net>
  <appender name="ForegroundPropagation" type="log4net.Appender.ForegroundPropagationAppender, log4net.ForegroundPropagation">
    <layout type="log4net.Layout.PatternLayout">
      <conversionPattern value="%message" />
    </layout>
    <filter type="log4net.Filter.LevelRangeFilter">
      <levelMin value="INFO"/>
      <levelMax value="ERROR"/>
    </filter>
  </appender>
  <root>
    <level value="ALL"/>
    <appender-ref ref="ForegroundPropagation"/>
  </root>
</log4net>
```
