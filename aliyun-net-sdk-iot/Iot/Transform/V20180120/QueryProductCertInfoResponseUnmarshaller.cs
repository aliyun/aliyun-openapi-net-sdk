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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryProductCertInfoResponseUnmarshaller
    {
        public static QueryProductCertInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryProductCertInfoResponse queryProductCertInfoResponse = new QueryProductCertInfoResponse();

			queryProductCertInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryProductCertInfoResponse.RequestId = _ctx.StringValue("QueryProductCertInfo.RequestId");
			queryProductCertInfoResponse.Success = _ctx.BooleanValue("QueryProductCertInfo.Success");
			queryProductCertInfoResponse.Code = _ctx.StringValue("QueryProductCertInfo.Code");
			queryProductCertInfoResponse.ErrorMessage = _ctx.StringValue("QueryProductCertInfo.ErrorMessage");

			QueryProductCertInfoResponse.QueryProductCertInfo_ProductCertInfo productCertInfo = new QueryProductCertInfoResponse.QueryProductCertInfo_ProductCertInfo();
			productCertInfo.IssueModel = _ctx.IntegerValue("QueryProductCertInfo.ProductCertInfo.IssueModel");
			queryProductCertInfoResponse.ProductCertInfo = productCertInfo;
        
			return queryProductCertInfoResponse;
        }
    }
}
