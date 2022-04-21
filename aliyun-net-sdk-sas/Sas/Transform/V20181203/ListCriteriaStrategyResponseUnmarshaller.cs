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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class ListCriteriaStrategyResponseUnmarshaller
    {
        public static ListCriteriaStrategyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCriteriaStrategyResponse listCriteriaStrategyResponse = new ListCriteriaStrategyResponse();

			listCriteriaStrategyResponse.HttpResponse = _ctx.HttpResponse;
			listCriteriaStrategyResponse.Success = _ctx.BooleanValue("ListCriteriaStrategy.Success");
			listCriteriaStrategyResponse.Code = _ctx.StringValue("ListCriteriaStrategy.Code");
			listCriteriaStrategyResponse.Message = _ctx.StringValue("ListCriteriaStrategy.Message");
			listCriteriaStrategyResponse.RequestId = _ctx.StringValue("ListCriteriaStrategy.RequestId");

			List<ListCriteriaStrategyResponse.ListCriteriaStrategy_DataItem> listCriteriaStrategyResponse_data = new List<ListCriteriaStrategyResponse.ListCriteriaStrategy_DataItem>();
			for (int i = 0; i < _ctx.Length("ListCriteriaStrategy.Data.Length"); i++) {
				ListCriteriaStrategyResponse.ListCriteriaStrategy_DataItem dataItem = new ListCriteriaStrategyResponse.ListCriteriaStrategy_DataItem();
				dataItem.Id = _ctx.LongValue("ListCriteriaStrategy.Data["+ i +"].Id");
				dataItem._Value = _ctx.StringValue("ListCriteriaStrategy.Data["+ i +"].Value");

				listCriteriaStrategyResponse_data.Add(dataItem);
			}
			listCriteriaStrategyResponse.Data = listCriteriaStrategyResponse_data;
        
			return listCriteriaStrategyResponse;
        }
    }
}
