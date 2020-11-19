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
        public static ExtractPedestrianFeatureAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExtractPedestrianFeatureAttributeResponse extractPedestrianFeatureAttributeResponse = new ExtractPedestrianFeatureAttributeResponse();

			extractPedestrianFeatureAttributeResponse.HttpResponse = _ctx.HttpResponse;
			extractPedestrianFeatureAttributeResponse.RequestId = _ctx.StringValue("ExtractPedestrianFeatureAttribute.RequestId");

			ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data data = new ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data();
			data.ObjType = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.ObjType");
			data.ObjTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.ObjTypeScore");
			data.Feature = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Feature");
			data.QualityScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.QualityScore");
			data.UpperColor = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.UpperColor");
			data.UpperColorScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.UpperColorScore");
			data.UpperType = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.UpperType");
			data.UpperTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.UpperTypeScore");
			data.LowerColor = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.LowerColor");
			data.LowerColorScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.LowerColorScore");
			data.LowerType = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.LowerType");
			data.LowerTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.LowerTypeScore");
			data.Gender = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Gender");
			data.GenderScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.GenderScore");
			data.Hair = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Hair");
			data.HairScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.HairScore");
			data.Age = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Age");
			data.AgeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.AgeScore");

			List<ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data.ExtractPedestrianFeatureAttribute_Element> data_elements = new List<ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data.ExtractPedestrianFeatureAttribute_Element>();
			for (int i = 0; i < _ctx.Length("ExtractPedestrianFeatureAttribute.Data.Elements.Length"); i++) {
				ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data.ExtractPedestrianFeatureAttribute_Element element = new ExtractPedestrianFeatureAttributeResponse.ExtractPedestrianFeatureAttribute_Data.ExtractPedestrianFeatureAttribute_Element();
				element.ObjType = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].ObjType");
				element.ObjTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].ObjTypeScore");
				element.Feature = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].Feature");
				element.QualityScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].QualityScore");
				element.UpperColor = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].UpperColor");
				element.UpperColorScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].UpperColorScore");
				element.UpperType = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].UpperType");
				element.UpperTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].UpperTypeScore");
				element.LowerColor = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].LowerColor");
				element.LowerColorScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].LowerColorScore");
				element.LowerType = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].LowerType");
				element.LowerTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].LowerTypeScore");
				element.Gender = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].Gender");
				element.GenderScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].GenderScore");
				element.Hair = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].Hair");
				element.HairScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].HairScore");
				element.Age = _ctx.StringValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].Age");
				element.AgeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttribute.Data.Elements["+ i +"].AgeScore");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			extractPedestrianFeatureAttributeResponse.Data = data;
        
			return extractPedestrianFeatureAttributeResponse;
        }
    }
}
