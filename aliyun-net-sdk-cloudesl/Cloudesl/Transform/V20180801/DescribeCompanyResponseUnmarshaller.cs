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
using Aliyun.Acs.cloudesl.Model.V20180801;

namespace Aliyun.Acs.cloudesl.Transform.V20180801
{
    public class DescribeCompanyResponseUnmarshaller
    {
        public static DescribeCompanyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCompanyResponse describeCompanyResponse = new DescribeCompanyResponse();

			describeCompanyResponse.HttpResponse = context.HttpResponse;
			describeCompanyResponse.RequestId = context.StringValue("DescribeCompany.RequestId");
			describeCompanyResponse.Success = context.BooleanValue("DescribeCompany.Success");
			describeCompanyResponse.Message = context.StringValue("DescribeCompany.Message");
			describeCompanyResponse.ErrorCode = context.StringValue("DescribeCompany.ErrorCode");
			describeCompanyResponse.CompanyId = context.StringValue("DescribeCompany.CompanyId");
			describeCompanyResponse.Platform = context.StringValue("DescribeCompany.Platform");
			describeCompanyResponse.Status = context.StringValue("DescribeCompany.Status");
        
			return describeCompanyResponse;
        }
    }
}
