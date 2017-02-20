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
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryDomainBySaleIdResponseUnmarshaller
    {
        public static QueryDomainBySaleIdResponse Unmarshall(UnmarshallerContext context)
        {
            QueryDomainBySaleIdResponse queryDomainBySaleIdResponse = new QueryDomainBySaleIdResponse()
            {
                HttpResponse = context.HttpResponse,
                UserId = context.StringValue("QueryDomainBySaleId.UserId"),
                DomainName = context.StringValue("QueryDomainBySaleId.DomainName"),
                SaleId = context.StringValue("QueryDomainBySaleId.SaleId"),
                CreationDate = context.StringValue("QueryDomainBySaleId.CreationDate"),
                ExpirationDate = context.StringValue("QueryDomainBySaleId.ExpirationDate"),
                DomainRegType = context.StringValue("QueryDomainBySaleId.DomainRegType"),
                EnglishHolder = context.StringValue("QueryDomainBySaleId.EnglishHolder"),
                ChineseHolder = context.StringValue("QueryDomainBySaleId.ChineseHolder"),
                EnglishContactPerson = context.StringValue("QueryDomainBySaleId.EnglishContactPerson"),
                ChineseContactPerson = context.StringValue("QueryDomainBySaleId.ChineseContactPerson"),
                HolderEmail = context.StringValue("QueryDomainBySaleId.HolderEmail"),
                TransferOutStatus = context.StringValue("QueryDomainBySaleId.TransferOutStatus"),
                SafetyLock = context.StringValue("QueryDomainBySaleId.SafetyLock"),
                TransferLock = context.StringValue("QueryDomainBySaleId.TransferLock"),
                WhoisProtected = context.BooleanValue("QueryDomainBySaleId.WhoisProtected")
            };
            List<string> dnsList = new List<string>();
			for (int i = 0; i < context.Length("QueryDomainBySaleId.DnsList.Length"); i++) {
				dnsList.Add(context.StringValue($"QueryDomainBySaleId.DnsList[{i}]"));
			}
			queryDomainBySaleIdResponse.DnsList = dnsList;
        
			return queryDomainBySaleIdResponse;
        }
    }
}