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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectLogoResponseUnmarshaller
    {
        public static DetectLogoResponse Unmarshall(UnmarshallerContext context)
        {
			DetectLogoResponse detectLogoResponse = new DetectLogoResponse();

			detectLogoResponse.HttpResponse = context.HttpResponse;
			detectLogoResponse.RequestId = context.StringValue("DetectLogo.RequestId");

			List<string> detectLogoResponse_srcUris = new List<string>();
			for (int i = 0; i < context.Length("DetectLogo.SrcUris.Length"); i++) {
				detectLogoResponse_srcUris.Add(context.StringValue("DetectLogo.SrcUris["+ i +"]"));
			}
			detectLogoResponse.SrcUris = detectLogoResponse_srcUris;

			List<DetectLogoResponse.DetectLogo_SuccessDetailsItem> detectLogoResponse_successDetails = new List<DetectLogoResponse.DetectLogo_SuccessDetailsItem>();
			for (int i = 0; i < context.Length("DetectLogo.SuccessDetails.Length"); i++) {
				DetectLogoResponse.DetectLogo_SuccessDetailsItem successDetailsItem = new DetectLogoResponse.DetectLogo_SuccessDetailsItem();
				successDetailsItem.SrcUri = context.StringValue("DetectLogo.SuccessDetails["+ i +"].SrcUri");
				successDetailsItem.Time = context.StringValue("DetectLogo.SuccessDetails["+ i +"].Time");
				successDetailsItem.GetImageTime = context.StringValue("DetectLogo.SuccessDetails["+ i +"].GetImageTime");
				successDetailsItem.DetectTime = context.StringValue("DetectLogo.SuccessDetails["+ i +"].DetectTime");

				List<DetectLogoResponse.DetectLogo_SuccessDetailsItem.DetectLogo_LogoBoxDetailItem> successDetailsItem_logoBoxDetail = new List<DetectLogoResponse.DetectLogo_SuccessDetailsItem.DetectLogo_LogoBoxDetailItem>();
				for (int j = 0; j < context.Length("DetectLogo.SuccessDetails["+ i +"].LogoBoxDetail.Length"); j++) {
					DetectLogoResponse.DetectLogo_SuccessDetailsItem.DetectLogo_LogoBoxDetailItem logoBoxDetailItem = new DetectLogoResponse.DetectLogo_SuccessDetailsItem.DetectLogo_LogoBoxDetailItem();
					logoBoxDetailItem.PUID = context.StringValue("DetectLogo.SuccessDetails["+ i +"].LogoBoxDetail["+ j +"].PUID");
					logoBoxDetailItem.Type = context.StringValue("DetectLogo.SuccessDetails["+ i +"].LogoBoxDetail["+ j +"].Type");
					logoBoxDetailItem.Score = context.FloatValue("DetectLogo.SuccessDetails["+ i +"].LogoBoxDetail["+ j +"].Score");

					List<string> logoBoxDetailItem_box = new List<string>();
					for (int k = 0; k < context.Length("DetectLogo.SuccessDetails["+ i +"].LogoBoxDetail["+ j +"].Box.Length"); k++) {
						logoBoxDetailItem_box.Add(context.StringValue("DetectLogo.SuccessDetails["+ i +"].LogoBoxDetail["+ j +"].Box["+ k +"]"));
					}
					logoBoxDetailItem.Box = logoBoxDetailItem_box;

					successDetailsItem_logoBoxDetail.Add(logoBoxDetailItem);
				}
				successDetailsItem.LogoBoxDetail = successDetailsItem_logoBoxDetail;

				detectLogoResponse_successDetails.Add(successDetailsItem);
			}
			detectLogoResponse.SuccessDetails = detectLogoResponse_successDetails;

			List<DetectLogoResponse.DetectLogo_FailDetailsItem> detectLogoResponse_failDetails = new List<DetectLogoResponse.DetectLogo_FailDetailsItem>();
			for (int i = 0; i < context.Length("DetectLogo.FailDetails.Length"); i++) {
				DetectLogoResponse.DetectLogo_FailDetailsItem failDetailsItem = new DetectLogoResponse.DetectLogo_FailDetailsItem();
				failDetailsItem.SrcUri = context.StringValue("DetectLogo.FailDetails["+ i +"].SrcUri");
				failDetailsItem.Reason = context.StringValue("DetectLogo.FailDetails["+ i +"].Reason");

				detectLogoResponse_failDetails.Add(failDetailsItem);
			}
			detectLogoResponse.FailDetails = detectLogoResponse_failDetails;
        
			return detectLogoResponse;
        }
    }
}
