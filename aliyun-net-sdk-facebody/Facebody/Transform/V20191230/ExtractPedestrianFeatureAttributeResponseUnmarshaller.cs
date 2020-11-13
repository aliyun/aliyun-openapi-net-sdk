/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class ExtractPedestrianFeatureAttributeResponseUnmarshaller
    {
        public static ExtractPedestrianFeatureAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			ExtractPedestrianFeatureAttributeResponse extractPedestrianFeatureAttributeResponse = new ExtractPedestrianFeatureAttributeResponse();

			extractPedestrianFeatureAttributeResponse.HttpResponse = context.HttpResponse;
			extractPedestrianFeatureAttributeResponse.RequestId = context.StringValue("ExtractPedestrianFeatureAttribute.RequestId");

			ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data data = new ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data();
			data.ObjType = context.StringValue("ExtractPedestrianFeatureAttribute.Data.ObjType");
			data.ObjTypeScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.ObjTypeScore");
			data.Feature = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Feature");
			data.QualityScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.QualityScore");
			data.UpperColor = context.StringValue("ExtractPedestrianFeatureAttribute.Data.UpperColor");
			data.UpperColorScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.UpperColorScore");
			data.UpperType = context.StringValue("ExtractPedestrianFeatureAttribute.Data.UpperType");
			data.UpperTypeScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.UpperTypeScore");
			data.LowerColor = context.StringValue("ExtractPedestrianFeatureAttribute.Data.LowerColor");
			data.LowerColorScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.LowerColorScore");
			data.LowerType = context.StringValue("ExtractPedestrianFeatureAttribute.Data.LowerType");
			data.LowerTypeScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.LowerTypeScore");
			data.Gender = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Gender");
			data.GenderScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.GenderScore");
			data.Hair = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Hair");
			data.HairScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.HairScore");
			data.Age = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Age");
			data.AgeScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.AgeScore");

			List<ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data.ExtractPedestrianFeatureAttribute_Element> data_elements = new List<ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data.ExtractPedestrianFeatureAttribute_Element>();
			for (int i = 0; i < context.Length("ExtractPedestrianFeatureAttribute.Data.Elements.Length"); i++) {
				ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data.ExtractPedestrianFeatureAttribute_Element element = new ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data.ExtractPedestrianFeatureAttribute_Element();
				element.ObjType = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].ObjType");
				element.ObjTypeScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].ObjTypeScore");
				element.Feature = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].Feature");
				element.QualityScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].QualityScore");
				element.UpperColor = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].UpperColor");
				element.UpperColorScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].UpperColorScore");
				element.UpperType = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].UpperType");
				element.UpperTypeScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].UpperTypeScore");
				element.LowerColor = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].LowerColor");
				element.LowerColorScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].LowerColorScore");
				element.LowerType = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].LowerType");
				element.LowerTypeScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].LowerTypeScore");
				element.Gender = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].Gender");
				element.GenderScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].GenderScore");
				element.Hair = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].Hair");
				element.HairScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].HairScore");
				element.Age = context.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].Age");
				element.AgeScore = context.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].AgeScore");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			extractPedestrianFeatureAttributeResponse.Data = data;
        
			return extractPedestrianFeatureAttributeResponse;
        }
    }
}
