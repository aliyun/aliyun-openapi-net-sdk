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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetFaceModelResultResponseUnmarshaller
    {
        public static GetFaceModelResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetFaceModelResultResponse getFaceModelResultResponse = new GetFaceModelResultResponse();

			getFaceModelResultResponse.HttpResponse = context.HttpResponse;
			getFaceModelResultResponse.Code = context.StringValue("GetFaceModelResult.Code");
			getFaceModelResultResponse.Message = context.StringValue("GetFaceModelResult.Message");
			getFaceModelResultResponse.RequestId = context.StringValue("GetFaceModelResult.RequestId");

			GetFaceModelResultResponse.GetFaceModelResult_Data data = new GetFaceModelResultResponse.GetFaceModelResult_Data();

			List<GetFaceModelResultResponse.GetFaceModelResult_Data.GetFaceModelResult_RecordsItem> data_records = new List<GetFaceModelResultResponse.GetFaceModelResult_Data.GetFaceModelResult_RecordsItem>();
			for (int i = 0; i < context.Length("GetFaceModelResult.Data.Records.Length"); i++) {
				GetFaceModelResultResponse.GetFaceModelResult_Data.GetFaceModelResult_RecordsItem recordsItem = new GetFaceModelResultResponse.GetFaceModelResult_Data.GetFaceModelResult_RecordsItem();
				recordsItem.MustacheStyle = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].MustacheStyle");
				recordsItem.FaceStyle = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].FaceStyle");
				recordsItem.CapStyle = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].CapStyle");
				recordsItem.SkinColor = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].SkinColor");
				recordsItem.RightBottomY = context.FloatValue("GetFaceModelResult.Data.Records["+ i +"].RightBottomY");
				recordsItem.RightBottomX = context.FloatValue("GetFaceModelResult.Data.Records["+ i +"].RightBottomX");
				recordsItem.HairStyle = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].HairStyle");
				recordsItem.GenderCode = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].GenderCode");
				recordsItem.RespiratorColor = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].RespiratorColor");
				recordsItem.EthicCode = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].EthicCode");
				recordsItem.AgeLowerLimit = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].AgeLowerLimit");
				recordsItem.LeftTopY = context.FloatValue("GetFaceModelResult.Data.Records["+ i +"].LeftTopY");
				recordsItem.LeftTopX = context.FloatValue("GetFaceModelResult.Data.Records["+ i +"].LeftTopX");
				recordsItem.HairColor = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].HairColor");
				recordsItem.AgeUpLimit = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].AgeUpLimit");
				recordsItem.GlassStyle = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].GlassStyle");
				recordsItem.GlassColor = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].GlassColor");
				recordsItem.CapColor = context.IntegerValue("GetFaceModelResult.Data.Records["+ i +"].CapColor");
				recordsItem.CapColorReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].CapColorReliability");
				recordsItem.RespiratorColorReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].RespiratorColorReliability");
				recordsItem.EthicCodeReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].EthicCodeReliability");
				recordsItem.GenderCodeReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].GenderCodeReliability");
				recordsItem.GlassColorReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].GlassColorReliability");
				recordsItem.SkinColorReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].SkinColorReliability");
				recordsItem.MustacheStyleReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].MustacheStyleReliability");
				recordsItem.CapStyleReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].CapStyleReliability");
				recordsItem.FaceStyleReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].FaceStyleReliability");
				recordsItem.GlassStyleReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].GlassStyleReliability");
				recordsItem.AgeUpLimitReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].AgeUpLimitReliability");
				recordsItem.HairStyleReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].HairStyleReliability");
				recordsItem.AgeLowerLimitReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].AgeLowerLimitReliability");
				recordsItem.HairColorReliability = context.StringValue("GetFaceModelResult.Data.Records["+ i +"].HairColorReliability");

				List<string> recordsItem_featureData = new List<string>();
				for (int j = 0; j < context.Length("GetFaceModelResult.Data.Records["+ i +"].FeatureData.Length"); j++) {
					recordsItem_featureData.Add(context.StringValue("GetFaceModelResult.Data.Records["+ i +"].FeatureData["+ j +"]"));
				}
				recordsItem.FeatureData = recordsItem_featureData;

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			getFaceModelResultResponse.Data = data;
        
			return getFaceModelResultResponse;
        }
    }
}
