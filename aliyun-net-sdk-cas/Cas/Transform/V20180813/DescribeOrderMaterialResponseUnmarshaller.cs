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
    public class DescribeOrderMaterialResponseUnmarshaller
    {
        public static DescribeOrderMaterialResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrderMaterialResponse describeOrderMaterialResponse = new DescribeOrderMaterialResponse();

			describeOrderMaterialResponse.HttpResponse = context.HttpResponse;
			describeOrderMaterialResponse.RequestId = context.StringValue("DescribeOrderMaterial.RequestId");
			describeOrderMaterialResponse.CompanyName = context.StringValue("DescribeOrderMaterial.CompanyName");
			describeOrderMaterialResponse.CompanyPhone = context.StringValue("DescribeOrderMaterial.CompanyPhone");
			describeOrderMaterialResponse.CompanyCode = context.StringValue("DescribeOrderMaterial.CompanyCode");
			describeOrderMaterialResponse.PersonName = context.StringValue("DescribeOrderMaterial.PersonName");
			describeOrderMaterialResponse.PersonPhone = context.StringValue("DescribeOrderMaterial.PersonPhone");
			describeOrderMaterialResponse.PersonEmail = context.StringValue("DescribeOrderMaterial.PersonEmail");
			describeOrderMaterialResponse.CompanyEmail = context.StringValue("DescribeOrderMaterial.CompanyEmail");
			describeOrderMaterialResponse.CompanyAddress = context.StringValue("DescribeOrderMaterial.CompanyAddress");
			describeOrderMaterialResponse.PersonIdCardNumber = context.StringValue("DescribeOrderMaterial.PersonIdCardNumber");
			describeOrderMaterialResponse.CompanyType = context.IntegerValue("DescribeOrderMaterial.CompanyType");
			describeOrderMaterialResponse.City = context.StringValue("DescribeOrderMaterial.City");
			describeOrderMaterialResponse.Province = context.StringValue("DescribeOrderMaterial.Province");
			describeOrderMaterialResponse.CreateCsr = context.IntegerValue("DescribeOrderMaterial.CreateCsr");
			describeOrderMaterialResponse.PostCode = context.StringValue("DescribeOrderMaterial.PostCode");
			describeOrderMaterialResponse.CsrContent = context.StringValue("DescribeOrderMaterial.CsrContent");
			describeOrderMaterialResponse.PersonTitle = context.StringValue("DescribeOrderMaterial.PersonTitle");
			describeOrderMaterialResponse.LeaderName = context.StringValue("DescribeOrderMaterial.LeaderName");
			describeOrderMaterialResponse.LeaderTitle = context.StringValue("DescribeOrderMaterial.LeaderTitle");
			describeOrderMaterialResponse.LeaderEmail = context.StringValue("DescribeOrderMaterial.LeaderEmail");
			describeOrderMaterialResponse.LeaderPhone = context.StringValue("DescribeOrderMaterial.LeaderPhone");
			describeOrderMaterialResponse.CountryCode = context.StringValue("DescribeOrderMaterial.CountryCode");
			describeOrderMaterialResponse.PersonDepartment = context.StringValue("DescribeOrderMaterial.PersonDepartment");
			describeOrderMaterialResponse.DomainAuthType = context.IntegerValue("DescribeOrderMaterial.DomainAuthType");
			describeOrderMaterialResponse.Domain = context.StringValue("DescribeOrderMaterial.Domain");
        
			return describeOrderMaterialResponse;
        }
    }
}
