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
using Aliyun.Acs.Cloudauth.Model.V20201112;

namespace Aliyun.Acs.Cloudauth.Transform.V20201112
{
    public class DescribeVerifyResultResponseUnmarshaller
    {
        public static DescribeVerifyResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVerifyResultResponse describeVerifyResultResponse = new DescribeVerifyResultResponse();

			describeVerifyResultResponse.HttpResponse = _ctx.HttpResponse;
			describeVerifyResultResponse.RequestId = _ctx.StringValue("DescribeVerifyResult.RequestId");
			describeVerifyResultResponse.Code = _ctx.StringValue("DescribeVerifyResult.Code");
			describeVerifyResultResponse.Message = _ctx.StringValue("DescribeVerifyResult.Message");
			describeVerifyResultResponse.Success = _ctx.BooleanValue("DescribeVerifyResult.Success");

			DescribeVerifyResultResponse.DescribeVerifyResult_ResultObject resultObject = new DescribeVerifyResultResponse.DescribeVerifyResult_ResultObject();
			resultObject.VerifyStatus = _ctx.IntegerValue("DescribeVerifyResult.ResultObject.VerifyStatus");
			resultObject.AuthorityComparisionScore = _ctx.FloatValue("DescribeVerifyResult.ResultObject.AuthorityComparisionScore");
			resultObject.FaceComparisonScore = _ctx.FloatValue("DescribeVerifyResult.ResultObject.FaceComparisonScore");
			resultObject.IdCardFaceComparisonScore = _ctx.FloatValue("DescribeVerifyResult.ResultObject.IdCardFaceComparisonScore");

			DescribeVerifyResultResponse.DescribeVerifyResult_ResultObject.DescribeVerifyResult_Material material = new DescribeVerifyResultResponse.DescribeVerifyResult_ResultObject.DescribeVerifyResult_Material();
			material.FaceImageUrl = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.FaceImageUrl");
			material.IdCardName = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardName");
			material.IdCardNumber = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardNumber");
			material.FaceQuality = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.FaceQuality");
			material.FaceGlobalUrl = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.FaceGlobalUrl");
			material.FaceMask = _ctx.BooleanValue("DescribeVerifyResult.ResultObject.Material.FaceMask");

			List<string> material_videoUrls = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeVerifyResult.ResultObject.Material.VideoUrls.Length"); i++) {
				material_videoUrls.Add(_ctx.StringValue("DescribeVerifyResult.ResultObject.Material.VideoUrls["+ i +"]"));
			}
			material.VideoUrls = material_videoUrls;

			DescribeVerifyResultResponse.DescribeVerifyResult_ResultObject.DescribeVerifyResult_Material.DescribeVerifyResult_IdCardInfo idCardInfo = new DescribeVerifyResultResponse.DescribeVerifyResult_ResultObject.DescribeVerifyResult_Material.DescribeVerifyResult_IdCardInfo();
			idCardInfo.Number = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.Number");
			idCardInfo.Address = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.Address");
			idCardInfo.Nationality = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.Nationality");
			idCardInfo.EndDate = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.EndDate");
			idCardInfo.FrontImageUrl = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.FrontImageUrl");
			idCardInfo.Authority = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.Authority");
			idCardInfo.Sex = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.Sex");
			idCardInfo.Name = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.Name");
			idCardInfo.Birth = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.Birth");
			idCardInfo.BackImageUrl = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.BackImageUrl");
			idCardInfo.StartDate = _ctx.StringValue("DescribeVerifyResult.ResultObject.Material.IdCardInfo.StartDate");
			material.IdCardInfo = idCardInfo;
			resultObject.Material = material;
			describeVerifyResultResponse.ResultObject = resultObject;
        
			return describeVerifyResultResponse;
        }
    }
}
