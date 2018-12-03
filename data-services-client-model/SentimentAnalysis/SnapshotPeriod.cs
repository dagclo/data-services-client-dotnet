/* 
 * Sentiment Analysis
 *
 * The Sentiment Analysis service offers insight into what customers are saying and feeling about your brand or product. Taking advantage of machine learning, the service can help you monitor customer perception and help influence the direction of your marketing and customer experience operations.  The service can analyze data from a variety of data sources, including Twitter and text contained in .csv files, say from customer support survey responses, and presents multiple visualizations of the results. You can review trends over time, easily learn what's hot and what's not based on the content of your data, and if you tap into the data in your Twitter feed, get a list of the topics that are the hottest and the messages that are the most intense.  Key functionality: * Steps you through setup with an easy to understand wizard. * Tracks sentiment per day/hour per topic. * Captures the most intense messages in periods ranging from seven to 30 days. * Provides sentiment visualizations that capture what topics your customers are discussing. 
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Quadient.DataServices.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServices.Model.SentimentAnalysis
{
    /// <summary>
    /// Defines snapshot_period
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SnapshotPeriod
    {
        
        /// <summary>
        /// Enum Hour for value: hour
        /// </summary>
        [EnumMember(Value = "hour")]
        Hour = 1,
        
        /// <summary>
        /// Enum Day for value: day
        /// </summary>
        [EnumMember(Value = "day")]
        Day = 2,
        
        /// <summary>
        /// Enum Month for value: month
        /// </summary>
        [EnumMember(Value = "month")]
        Month = 3
    }
}
