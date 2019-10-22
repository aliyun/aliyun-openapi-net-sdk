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
    public class DetectImageQRCodesResponseUnmarshaller
    {
        public static DetectImageQRCodesResponse Unmarshall(UnmarshallerContext context)
        {
			DetectImageQRCodesResponse detectImageQRCodesResponse = new DetectImageQRCodesResponse();

			detectImageQRCodesResponse.HttpResponse = context.HttpResponse;
			detectImageQRCodesResponse.RequestId = context.StringValue("DetectImageQRCodes.RequestId");
			detectImageQRCodesResponse.ImageUri = context.StringValue("DetectImageQRCodes.ImageUri");

			List<DetectImageQRCodesResponse.DetectImageQRCodes_QRCodesItem> detectImageQRCodesResponse_qRCodes = new List<DetectImageQRCodesResponse.DetectImageQRCodes_QRCodesItem>();
			for (int i = 0; i < context.Length("DetectImageQRCodes.QRCodes.Length"); i++) {
				DetectImageQRCodesResponse.DetectImageQRCodes_QRCodesItem qRCodesItem = new DetectImageQRCodesResponse.DetectImageQRCodes_QRCodesItem();
				qRCodesItem.Content = context.StringValue("DetectImageQRCodes.QRCodes["+ i +"].Content");

				DetectImageQRCodesResponse.DetectImageQRCodes_QRCodesItem.DetectImageQRCodes_QRCodeBoundary qRCodeBoundary = new DetectImageQRCodesResponse.DetectImageQRCodes_QRCodesItem.DetectImageQRCodes_QRCodeBoundary();
				qRCodeBoundary.Top = context.IntegerValue("DetectImageQRCodes.QRCodes["+ i +"].QRCodeBoundary.Top");
				qRCodeBoundary.Left = context.IntegerValue("DetectImageQRCodes.QRCodes["+ i +"].QRCodeBoundary.Left");
				qRCodeBoundary.Width = context.IntegerValue("DetectImageQRCodes.QRCodes["+ i +"].QRCodeBoundary.Width");
				qRCodeBoundary.Height = context.IntegerValue("DetectImageQRCodes.QRCodes["+ i +"].QRCodeBoundary.Height");
				qRCodesItem.QRCodeBoundary = qRCodeBoundary;

				detectImageQRCodesResponse_qRCodes.Add(qRCodesItem);
			}
			detectImageQRCodesResponse.QRCodes = detectImageQRCodesResponse_qRCodes;
        
			return detectImageQRCodesResponse;
        }
    }
}
