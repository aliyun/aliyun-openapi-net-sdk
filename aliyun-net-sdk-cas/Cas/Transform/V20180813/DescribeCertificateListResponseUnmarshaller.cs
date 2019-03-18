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
    public class DescribeCertificateListResponseUnmarshaller
    {
        public static DescribeCertificateListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCertificateListResponse describeCertificateListResponse = new DescribeCertificateListResponse();

			describeCertificateListResponse.HttpResponse = context.HttpResponse;
			describeCertificateListResponse.RequestId = context.StringValue("DescribeCertificateList.RequestId");
			describeCertificateListResponse.TotalCount = context.IntegerValue("DescribeCertificateList.TotalCount");
			describeCertificateListResponse.ShowSize = context.IntegerValue("DescribeCertificateList.ShowSize");
			describeCertificateListResponse.CurrentPage = context.IntegerValue("DescribeCertificateList.CurrentPage");

			List<DescribeCertificateListResponse.DescribeCertificateList_Certificate> describeCertificateListResponse_certificateList = new List<DescribeCertificateListResponse.DescribeCertificateList_Certificate>();
			for (int i = 0; i < context.Length("DescribeCertificateList.CertificateList.Length"); i++) {
				DescribeCertificateListResponse.DescribeCertificateList_Certificate certificate = new DescribeCertificateListResponse.DescribeCertificateList_Certificate();
				certificate.Id = context.LongValue("DescribeCertificateList.CertificateList["+ i +"].Id");
				certificate.Name = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].Name");
				certificate.SourceType = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].SourceType");
				certificate.CertType = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].CertType");
				certificate.InstanceId = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].InstanceId");
				certificate.OrderId = context.LongValue("DescribeCertificateList.CertificateList["+ i +"].OrderId");
				certificate.OrderType = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].OrderType");
				certificate.BrandName = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].BrandName");
				certificate.BeforeDate = context.LongValue("DescribeCertificateList.CertificateList["+ i +"].BeforeDate");
				certificate.AfterDate = context.LongValue("DescribeCertificateList.CertificateList["+ i +"].AfterDate");
				certificate.Year = context.IntegerValue("DescribeCertificateList.CertificateList["+ i +"].Year");
				certificate.Domain = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].Domain");
				certificate.RemainingDays = context.IntegerValue("DescribeCertificateList.CertificateList["+ i +"].RemainingDays");
				certificate.DeploymentCloudProduct = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].DeploymentCloudProduct");
				certificate.StatusCode = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].StatusCode");
				certificate.NewBuyCertType = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].NewBuyCertType");
				certificate.NewBuyDomainType = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].NewBuyDomainType");
				certificate.NewBuyBrand = context.StringValue("DescribeCertificateList.CertificateList["+ i +"].NewBuyBrand");
				certificate.ShowDeployment = context.IntegerValue("DescribeCertificateList.CertificateList["+ i +"].ShowDeployment");

				describeCertificateListResponse_certificateList.Add(certificate);
			}
			describeCertificateListResponse.CertificateList = describeCertificateListResponse_certificateList;
        
			return describeCertificateListResponse;
        }
    }
}
