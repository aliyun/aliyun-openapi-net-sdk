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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeCertificateDetailResponseUnmarshaller
    {
        public static DescribeCertificateDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCertificateDetailResponse describeCertificateDetailResponse = new DescribeCertificateDetailResponse();

			describeCertificateDetailResponse.HttpResponse = context.HttpResponse;
			describeCertificateDetailResponse.RequestId = context.StringValue("DescribeCertificateDetail.RequestId");
			describeCertificateDetailResponse.Id = context.LongValue("DescribeCertificateDetail.Id");
			describeCertificateDetailResponse.SourceType = context.StringValue("DescribeCertificateDetail.SourceType");
			describeCertificateDetailResponse.InstanceId = context.StringValue("DescribeCertificateDetail.InstanceId");
			describeCertificateDetailResponse.Name = context.StringValue("DescribeCertificateDetail.Name");
			describeCertificateDetailResponse.OrderId = context.LongValue("DescribeCertificateDetail.OrderId");
			describeCertificateDetailResponse.Year = context.IntegerValue("DescribeCertificateDetail.Year");
			describeCertificateDetailResponse.BeforeDate = context.LongValue("DescribeCertificateDetail.BeforeDate");
			describeCertificateDetailResponse.AfterDate = context.LongValue("DescribeCertificateDetail.AfterDate");
			describeCertificateDetailResponse.FingerPrint = context.StringValue("DescribeCertificateDetail.FingerPrint");
			describeCertificateDetailResponse.Domains = context.StringValue("DescribeCertificateDetail.Domains");
			describeCertificateDetailResponse.StatusCode = context.StringValue("DescribeCertificateDetail.StatusCode");
			describeCertificateDetailResponse.BrandName = context.StringValue("DescribeCertificateDetail.BrandName");
			describeCertificateDetailResponse.CertType = context.StringValue("DescribeCertificateDetail.CertType");
			describeCertificateDetailResponse.RemainingDays = context.IntegerValue("DescribeCertificateDetail.RemainingDays");
        
			return describeCertificateDetailResponse;
        }
    }
}
