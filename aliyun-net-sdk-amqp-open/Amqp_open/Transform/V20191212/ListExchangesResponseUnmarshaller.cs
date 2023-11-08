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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class ListExchangesResponseUnmarshaller
    {
        public static ListExchangesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListExchangesResponse listExchangesResponse = new ListExchangesResponse();

			listExchangesResponse.HttpResponse = _ctx.HttpResponse;
			listExchangesResponse.RequestId = _ctx.StringValue("ListExchanges.RequestId");

			ListExchangesResponse.ListExchanges_Data data = new ListExchangesResponse.ListExchanges_Data();
			data.MaxResults = _ctx.IntegerValue("ListExchanges.Data.MaxResults");
			data.NextToken = _ctx.StringValue("ListExchanges.Data.NextToken");

			List<ListExchangesResponse.ListExchanges_Data.ListExchanges_ExchangeVO> data_exchanges = new List<ListExchangesResponse.ListExchanges_Data.ListExchanges_ExchangeVO>();
			for (int i = 0; i < _ctx.Length("ListExchanges.Data.Exchanges.Length"); i++) {
				ListExchangesResponse.ListExchanges_Data.ListExchanges_ExchangeVO exchangeVO = new ListExchangesResponse.ListExchanges_Data.ListExchanges_ExchangeVO();
				exchangeVO.AutoDeleteState = _ctx.BooleanValue("ListExchanges.Data.Exchanges["+ i +"].AutoDeleteState");
				exchangeVO.CreateTime = _ctx.LongValue("ListExchanges.Data.Exchanges["+ i +"].CreateTime");
				exchangeVO.Attributes = _ctx.StringValue("ListExchanges.Data.Exchanges["+ i +"].Attributes");
				exchangeVO.VHostName = _ctx.StringValue("ListExchanges.Data.Exchanges["+ i +"].VHostName");
				exchangeVO.Name = _ctx.StringValue("ListExchanges.Data.Exchanges["+ i +"].Name");
				exchangeVO.ExchangeType = _ctx.StringValue("ListExchanges.Data.Exchanges["+ i +"].ExchangeType");

				data_exchanges.Add(exchangeVO);
			}
			data.Exchanges = data_exchanges;
			listExchangesResponse.Data = data;
        
			return listExchangesResponse;
        }
    }
}
