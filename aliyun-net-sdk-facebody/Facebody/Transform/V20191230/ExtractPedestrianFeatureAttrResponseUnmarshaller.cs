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
    public class ExtractPedestrianFeatureAttrResponseUnmarshaller
    {
        public static ExtractPedestrianFeatureAttrResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExtractPedestrianFeatureAttrResponse extractPedestrianFeatureAttrResponse = new ExtractPedestrianFeatureAttrResponse();

			extractPedestrianFeatureAttrResponse.HttpResponse = _ctx.HttpResponse;
			extractPedestrianFeatureAttrResponse.RequestId = _ctx.StringValue("ExtractPedestrianFeatureAttr.RequestId");

			ExtractPedestrianFeatureAttrResponse.ExtractPedestrianFeatureAttr_Data data = new ExtractPedestrianFeatureAttrResponse.ExtractPedestrianFeatureAttr_Data();
			data.ObjType = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.ObjType");
			data.ObjTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.ObjTypeScore");
			data.Feature = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.Feature");
			data.QualityScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.QualityScore");
			data.UpperColor = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.UpperColor");
			data.UpperColorScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.UpperColorScore");
			data.UpperType = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.UpperType");
			data.UpperTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.UpperTypeScore");
			data.LowerColor = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.LowerColor");
			data.LowerColorScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.LowerColorScore");
			data.LowerType = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.LowerType");
			data.LowerTypeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.LowerTypeScore");
			data.Gender = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.Gender");
			data.GenderScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.GenderScore");
			data.Hair = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.Hair");
			data.HairScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.HairScore");
			data.Age = _ctx.StringValue("ExtractPedestrianFeatureAttr.Data.Age");
			data.AgeScore = _ctx.FloatValue("ExtractPedestrianFeatureAttr.Data.AgeScore");
			extractPedestrianFeatureAttrResponse.Data = data;
        
			return extractPedestrianFeatureAttrResponse;
        }
    }
}
