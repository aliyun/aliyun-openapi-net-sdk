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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribeVerifyResultResponseUnmarshaller
    {
        public static DescribeVerifyResultResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVerifyResultResponse describeVerifyResultResponse = new DescribeVerifyResultResponse();

			describeVerifyResultResponse.HttpResponse = context.HttpResponse;
			describeVerifyResultResponse.RequestId = context.StringValue("DescribeVerifyResult.RequestId");
			describeVerifyResultResponse.VerifyStatus = context.IntegerValue("DescribeVerifyResult.VerifyStatus");
			describeVerifyResultResponse.AuthorityComparisionScore = context.FloatValue("DescribeVerifyResult.AuthorityComparisionScore");
			describeVerifyResultResponse.FaceComparisonScore = context.FloatValue("DescribeVerifyResult.FaceComparisonScore");
			describeVerifyResultResponse.IdCardFaceComparisonScore = context.FloatValue("DescribeVerifyResult.IdCardFaceComparisonScore");

			DescribeVerifyResultResponse.DescribeVerifyResult_Material material = new DescribeVerifyResultResponse.DescribeVerifyResult_Material();
			material.FaceImageUrl = context.StringValue("DescribeVerifyResult.Material.FaceImageUrl");
			material.IdCardName = context.StringValue("DescribeVerifyResult.Material.IdCardName");
			material.IdCardNumber = context.StringValue("DescribeVerifyResult.Material.IdCardNumber");
			material.FaceQuality = context.StringValue("DescribeVerifyResult.Material.FaceQuality");
			material.FaceGlobalUrl = context.StringValue("DescribeVerifyResult.Material.FaceGlobalUrl");
			material.FaceMask = context.BooleanValue("DescribeVerifyResult.Material.FaceMask");

			List<string> material_videoUrls = new List<string>();
			for (int i = 0; i < context.Length("DescribeVerifyResult.Material.VideoUrls.Length"); i++) {
				material_videoUrls.Add(context.StringValue("DescribeVerifyResult.Material.VideoUrls["+ i +"]"));
			}
			material.VideoUrls = material_videoUrls;

			DescribeVerifyResultResponse.DescribeVerifyResult_Material.DescribeVerifyResult_IdCardInfo idCardInfo = new DescribeVerifyResultResponse.DescribeVerifyResult_Material.DescribeVerifyResult_IdCardInfo();
			idCardInfo.Number = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.Number");
			idCardInfo.Address = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.Address");
			idCardInfo.Nationality = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.Nationality");
			idCardInfo.EndDate = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.EndDate");
			idCardInfo.FrontImageUrl = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.FrontImageUrl");
			idCardInfo.Authority = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.Authority");
			idCardInfo.Sex = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.Sex");
			idCardInfo.Name = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.Name");
			idCardInfo.Birth = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.Birth");
			idCardInfo.BackImageUrl = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.BackImageUrl");
			idCardInfo.StartDate = context.StringValue("DescribeVerifyResult.Material.IdCardInfo.StartDate");
			material.IdCardInfo = idCardInfo;
			describeVerifyResultResponse.Material = material;
        
			return describeVerifyResultResponse;
        }
    }
}
