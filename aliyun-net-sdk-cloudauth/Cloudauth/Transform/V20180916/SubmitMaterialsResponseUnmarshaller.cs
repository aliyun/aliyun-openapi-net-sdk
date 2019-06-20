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
using Aliyun.Acs.Cloudauth.Model.V20180916;

namespace Aliyun.Acs.Cloudauth.Transform.V20180916
{
    public class SubmitMaterialsResponseUnmarshaller
    {
        public static SubmitMaterialsResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitMaterialsResponse submitMaterialsResponse = new SubmitMaterialsResponse();

			submitMaterialsResponse.HttpResponse = context.HttpResponse;
			submitMaterialsResponse.RequestId = context.StringValue("SubmitMaterials.RequestId");
			submitMaterialsResponse.Success = context.BooleanValue("SubmitMaterials.Success");
			submitMaterialsResponse.Code = context.StringValue("SubmitMaterials.Code");
			submitMaterialsResponse.Message = context.StringValue("SubmitMaterials.Message");

			SubmitMaterialsResponse.SubmitMaterials_Data data = new SubmitMaterialsResponse.SubmitMaterials_Data();

			SubmitMaterialsResponse.SubmitMaterials_Data.SubmitMaterials_VerifyStatus verifyStatus = new SubmitMaterialsResponse.SubmitMaterials_Data.SubmitMaterials_VerifyStatus();
			verifyStatus.StatusCode = context.IntegerValue("SubmitMaterials.Data.VerifyStatus.StatusCode");
			verifyStatus.TrustedScore = context.FloatValue("SubmitMaterials.Data.VerifyStatus.TrustedScore");
			verifyStatus.SimilarityScore = context.FloatValue("SubmitMaterials.Data.VerifyStatus.SimilarityScore");
			verifyStatus.AuditConclusions = context.StringValue("SubmitMaterials.Data.VerifyStatus.AuditConclusions");
			verifyStatus.AuthorityComparisonScore = context.FloatValue("SubmitMaterials.Data.VerifyStatus.AuthorityComparisonScore");
			data.VerifyStatus = verifyStatus;
			submitMaterialsResponse.Data = data;
        
			return submitMaterialsResponse;
        }
    }
}
