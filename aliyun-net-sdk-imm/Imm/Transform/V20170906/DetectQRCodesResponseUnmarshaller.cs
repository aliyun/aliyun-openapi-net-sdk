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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectQRCodesResponseUnmarshaller
    {
        public static DetectQRCodesResponse Unmarshall(UnmarshallerContext context)
        {
			DetectQRCodesResponse detectQRCodesResponse = new DetectQRCodesResponse();

			detectQRCodesResponse.HttpResponse = context.HttpResponse;
			detectQRCodesResponse.RequestId = context.StringValue("DetectQRCodes.RequestId");

			List<DetectQRCodesResponse.DetectQRCodes_SuccessDetailsItem> detectQRCodesResponse_successDetails = new List<DetectQRCodesResponse.DetectQRCodes_SuccessDetailsItem>();
			for (int i = 0; i < context.Length("DetectQRCodes.SuccessDetails.Length"); i++) {
				DetectQRCodesResponse.DetectQRCodes_SuccessDetailsItem successDetailsItem = new DetectQRCodesResponse.DetectQRCodes_SuccessDetailsItem();
				successDetailsItem.SrcUri = context.StringValue("DetectQRCodes.SuccessDetails["+ i +"].SrcUri");
				successDetailsItem.Result = context.StringValue("DetectQRCodes.SuccessDetails["+ i +"].Result");

				DetectQRCodesResponse.DetectQRCodes_SuccessDetailsItem.DetectQRCodes_QRCodesRectangle qRCodesRectangle = new DetectQRCodesResponse.DetectQRCodes_SuccessDetailsItem.DetectQRCodes_QRCodesRectangle();
				qRCodesRectangle.Left = context.IntegerValue("DetectQRCodes.SuccessDetails["+ i +"].QRCodesRectangle.Left");
				qRCodesRectangle.Top = context.IntegerValue("DetectQRCodes.SuccessDetails["+ i +"].QRCodesRectangle.Top");
				qRCodesRectangle.Width = context.IntegerValue("DetectQRCodes.SuccessDetails["+ i +"].QRCodesRectangle.Width");
				qRCodesRectangle.Height = context.IntegerValue("DetectQRCodes.SuccessDetails["+ i +"].QRCodesRectangle.Height");
				successDetailsItem.QRCodesRectangle = qRCodesRectangle;

				detectQRCodesResponse_successDetails.Add(successDetailsItem);
			}
			detectQRCodesResponse.SuccessDetails = detectQRCodesResponse_successDetails;

			List<DetectQRCodesResponse.DetectQRCodes_FailDetailsItem> detectQRCodesResponse_failDetails = new List<DetectQRCodesResponse.DetectQRCodes_FailDetailsItem>();
			for (int i = 0; i < context.Length("DetectQRCodes.FailDetails.Length"); i++) {
				DetectQRCodesResponse.DetectQRCodes_FailDetailsItem failDetailsItem = new DetectQRCodesResponse.DetectQRCodes_FailDetailsItem();
				failDetailsItem.SrcUri = context.StringValue("DetectQRCodes.FailDetails["+ i +"].SrcUri");
				failDetailsItem.Reason = context.StringValue("DetectQRCodes.FailDetails["+ i +"].Reason");

				detectQRCodesResponse_failDetails.Add(failDetailsItem);
			}
			detectQRCodesResponse.FailDetails = detectQRCodesResponse_failDetails;
        
			return detectQRCodesResponse;
        }
    }
}