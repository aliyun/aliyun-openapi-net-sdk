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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class GetNotaryOrderResponseUnmarshaller
    {
        public static GetNotaryOrderResponse Unmarshall(UnmarshallerContext context)
        {
			GetNotaryOrderResponse getNotaryOrderResponse = new GetNotaryOrderResponse();

			getNotaryOrderResponse.HttpResponse = context.HttpResponse;
			getNotaryOrderResponse.RequestId = context.StringValue("GetNotaryOrder.RequestId");
			getNotaryOrderResponse.NotaryOrderId = context.LongValue("GetNotaryOrder.NotaryOrderId");
			getNotaryOrderResponse.AliyunOrderId = context.StringValue("GetNotaryOrder.AliyunOrderId");
			getNotaryOrderResponse.TmRegisterNo = context.StringValue("GetNotaryOrder.TmRegisterNo");
			getNotaryOrderResponse.TmName = context.StringValue("GetNotaryOrder.TmName");
			getNotaryOrderResponse.TmImage = context.StringValue("GetNotaryOrder.TmImage");
			getNotaryOrderResponse.TmClassification = context.StringValue("GetNotaryOrder.TmClassification");
			getNotaryOrderResponse.OrderPrice = context.FloatValue("GetNotaryOrder.OrderPrice");
			getNotaryOrderResponse.NotaryStatus = context.IntegerValue("GetNotaryOrder.NotaryStatus");
			getNotaryOrderResponse.Type = context.StringValue("GetNotaryOrder.Type");
			getNotaryOrderResponse.Name = context.StringValue("GetNotaryOrder.Name");
			getNotaryOrderResponse.Phone = context.StringValue("GetNotaryOrder.Phone");
			getNotaryOrderResponse.SellerCompanyName = context.StringValue("GetNotaryOrder.SellerCompanyName");
			getNotaryOrderResponse.BusinessLicenseId = context.StringValue("GetNotaryOrder.BusinessLicenseId");
			getNotaryOrderResponse.LegalPersonName = context.StringValue("GetNotaryOrder.LegalPersonName");
			getNotaryOrderResponse.LegalPersonPhone = context.StringValue("GetNotaryOrder.LegalPersonPhone");
			getNotaryOrderResponse.LegalPersonIdCard = context.StringValue("GetNotaryOrder.LegalPersonIdCard");
			getNotaryOrderResponse.CompanyContactName = context.StringValue("GetNotaryOrder.CompanyContactName");
			getNotaryOrderResponse.CompanyContactPhone = context.StringValue("GetNotaryOrder.CompanyContactPhone");
			getNotaryOrderResponse.TmRegisterCertificate = context.StringValue("GetNotaryOrder.TmRegisterCertificate");
			getNotaryOrderResponse.BusinessLicense = context.StringValue("GetNotaryOrder.BusinessLicense");
			getNotaryOrderResponse.TmAcceptCertificate = context.StringValue("GetNotaryOrder.TmAcceptCertificate");
			getNotaryOrderResponse.SellerFrontOfIdCard = context.StringValue("GetNotaryOrder.SellerFrontOfIdCard");
			getNotaryOrderResponse.SellerBackOfIdCard = context.StringValue("GetNotaryOrder.SellerBackOfIdCard");
			getNotaryOrderResponse.TmRegisterChangeCertificate = context.StringValue("GetNotaryOrder.TmRegisterChangeCertificate");
			getNotaryOrderResponse.ReceiverName = context.StringValue("GetNotaryOrder.ReceiverName");
			getNotaryOrderResponse.ReceiverAddress = context.StringValue("GetNotaryOrder.ReceiverAddress");
			getNotaryOrderResponse.ReceiverPhone = context.StringValue("GetNotaryOrder.ReceiverPhone");
			getNotaryOrderResponse.ReceiverPostalCode = context.StringValue("GetNotaryOrder.ReceiverPostalCode");
			getNotaryOrderResponse.OrderDate = context.LongValue("GetNotaryOrder.OrderDate");
			getNotaryOrderResponse.NotaryAcceptDate = context.LongValue("GetNotaryOrder.NotaryAcceptDate");
			getNotaryOrderResponse.NotarySucceedDate = context.LongValue("GetNotaryOrder.NotarySucceedDate");
			getNotaryOrderResponse.NotaryFailedDate = context.LongValue("GetNotaryOrder.NotaryFailedDate");
			getNotaryOrderResponse.NotaryFailedReason = context.StringValue("GetNotaryOrder.NotaryFailedReason");
			getNotaryOrderResponse.NotaryCertificate = context.StringValue("GetNotaryOrder.NotaryCertificate");
			getNotaryOrderResponse.Success = context.BooleanValue("GetNotaryOrder.Success");
			getNotaryOrderResponse.ErrorMsg = context.StringValue("GetNotaryOrder.ErrorMsg");
			getNotaryOrderResponse.ErrorCode = context.StringValue("GetNotaryOrder.ErrorCode");
			getNotaryOrderResponse.BizId = context.StringValue("GetNotaryOrder.BizId");
			getNotaryOrderResponse.NotaryType = context.IntegerValue("GetNotaryOrder.NotaryType");
			getNotaryOrderResponse.NotaryPlatformName = context.StringValue("GetNotaryOrder.NotaryPlatformName");
			getNotaryOrderResponse.ApplyPostStatus = context.IntegerValue("GetNotaryOrder.ApplyPostStatus");
			getNotaryOrderResponse.NotaryPostReceipt = context.StringValue("GetNotaryOrder.NotaryPostReceipt");
        
			return getNotaryOrderResponse;
        }
    }
}
