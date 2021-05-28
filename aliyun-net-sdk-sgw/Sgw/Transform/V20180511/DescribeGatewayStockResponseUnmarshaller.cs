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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewayStockResponseUnmarshaller
    {
        public static DescribeGatewayStockResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayStockResponse describeGatewayStockResponse = new DescribeGatewayStockResponse();

			describeGatewayStockResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayStockResponse.RequestId = _ctx.StringValue("DescribeGatewayStock.RequestId");
			describeGatewayStockResponse.Success = _ctx.BooleanValue("DescribeGatewayStock.Success");
			describeGatewayStockResponse.Code = _ctx.StringValue("DescribeGatewayStock.Code");
			describeGatewayStockResponse.Message = _ctx.StringValue("DescribeGatewayStock.Message");

			List<DescribeGatewayStockResponse.DescribeGatewayStock_Stock> describeGatewayStockResponse_stocks = new List<DescribeGatewayStockResponse.DescribeGatewayStock_Stock>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayStock.Stocks.Length"); i++) {
				DescribeGatewayStockResponse.DescribeGatewayStock_Stock stock = new DescribeGatewayStockResponse.DescribeGatewayStock_Stock();
				stock.ZoneId = _ctx.StringValue("DescribeGatewayStock.Stocks["+ i +"].ZoneId");
				stock.StockInfo = _ctx.StringValue("DescribeGatewayStock.Stocks["+ i +"].StockInfo");

				describeGatewayStockResponse_stocks.Add(stock);
			}
			describeGatewayStockResponse.Stocks = describeGatewayStockResponse_stocks;
        
			return describeGatewayStockResponse;
        }
    }
}
