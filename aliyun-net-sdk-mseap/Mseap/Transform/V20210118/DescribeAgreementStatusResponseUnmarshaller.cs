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
using Aliyun.Acs.mseap.Model.V20210118;

namespace Aliyun.Acs.mseap.Transform.V20210118
{
    public class DescribeAgreementStatusResponseUnmarshaller
    {
        public static DescribeAgreementStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAgreementStatusResponse describeAgreementStatusResponse = new DescribeAgreementStatusResponse();

			describeAgreementStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeAgreementStatusResponse.Status = _ctx.IntegerValue("DescribeAgreementStatus.Status");
			describeAgreementStatusResponse.RequestId = _ctx.StringValue("DescribeAgreementStatus.RequestId");
			describeAgreementStatusResponse.AgreementCode = _ctx.StringValue("DescribeAgreementStatus.AgreementCode");
			describeAgreementStatusResponse.UserId = _ctx.StringValue("DescribeAgreementStatus.UserId");
        
			return describeAgreementStatusResponse;
        }
    }
}
