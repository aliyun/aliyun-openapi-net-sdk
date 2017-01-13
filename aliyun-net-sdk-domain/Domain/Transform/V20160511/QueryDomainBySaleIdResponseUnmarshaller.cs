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
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryDomainBySaleIdResponseUnmarshaller
    {
        public static QueryDomainBySaleIdResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDomainBySaleIdResponse queryDomainBySaleIdResponse = new QueryDomainBySaleIdResponse();

			queryDomainBySaleIdResponse.HttpResponse = context.HttpResponse;
			queryDomainBySaleIdResponse.UserId = context.StringValue("QueryDomainBySaleId.UserId");
			queryDomainBySaleIdResponse.DomainName = context.StringValue("QueryDomainBySaleId.DomainName");
			queryDomainBySaleIdResponse.SaleId = context.StringValue("QueryDomainBySaleId.SaleId");
			queryDomainBySaleIdResponse.CreationDate = context.StringValue("QueryDomainBySaleId.CreationDate");
			queryDomainBySaleIdResponse.ExpirationDate = context.StringValue("QueryDomainBySaleId.ExpirationDate");
			queryDomainBySaleIdResponse.DomainRegType = context.StringValue("QueryDomainBySaleId.DomainRegType");
			queryDomainBySaleIdResponse.EnglishHolder = context.StringValue("QueryDomainBySaleId.EnglishHolder");
			queryDomainBySaleIdResponse.ChineseHolder = context.StringValue("QueryDomainBySaleId.ChineseHolder");
			queryDomainBySaleIdResponse.EnglishContactPerson = context.StringValue("QueryDomainBySaleId.EnglishContactPerson");
			queryDomainBySaleIdResponse.ChineseContactPerson = context.StringValue("QueryDomainBySaleId.ChineseContactPerson");
			queryDomainBySaleIdResponse.HolderEmail = context.StringValue("QueryDomainBySaleId.HolderEmail");
			queryDomainBySaleIdResponse.TransferOutStatus = context.StringValue("QueryDomainBySaleId.TransferOutStatus");
			queryDomainBySaleIdResponse.SafetyLock = context.StringValue("QueryDomainBySaleId.SafetyLock");
			queryDomainBySaleIdResponse.TransferLock = context.StringValue("QueryDomainBySaleId.TransferLock");
			queryDomainBySaleIdResponse.WhoisProtected = context.BooleanValue("QueryDomainBySaleId.WhoisProtected");

			List<string> dnsList = new List<string>();
			for (int i = 0; i < context.Length("QueryDomainBySaleId.DnsList.Length"); i++) {
				dnsList.Add(context.StringValue("QueryDomainBySaleId.DnsList["+ i +"]"));
			}
			queryDomainBySaleIdResponse.DnsList = dnsList;
        
			return queryDomainBySaleIdResponse;
        }
    }
}