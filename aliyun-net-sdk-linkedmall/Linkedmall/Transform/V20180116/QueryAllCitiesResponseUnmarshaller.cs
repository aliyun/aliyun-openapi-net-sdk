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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryAllCitiesResponseUnmarshaller
    {
        public static QueryAllCitiesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAllCitiesResponse queryAllCitiesResponse = new QueryAllCitiesResponse();

			queryAllCitiesResponse.HttpResponse = context.HttpResponse;
			queryAllCitiesResponse.RequestId = context.StringValue("QueryAllCities.RequestId");
			queryAllCitiesResponse.Code = context.StringValue("QueryAllCities.Code");
			queryAllCitiesResponse.Message = context.StringValue("QueryAllCities.Message");
			queryAllCitiesResponse.SubCode = context.StringValue("QueryAllCities.SubCode");
			queryAllCitiesResponse.SubMessage = context.StringValue("QueryAllCities.SubMessage");
			queryAllCitiesResponse.LogsId = context.StringValue("QueryAllCities.LogsId");
			queryAllCitiesResponse.Success = context.BooleanValue("QueryAllCities.Success");

			List<QueryAllCitiesResponse.QueryAllCities_City> queryAllCitiesResponse_cities = new List<QueryAllCitiesResponse.QueryAllCities_City>();
			for (int i = 0; i < context.Length("QueryAllCities.Cities.Length"); i++) {
				QueryAllCitiesResponse.QueryAllCities_City city = new QueryAllCitiesResponse.QueryAllCities_City();
				city.PinYin = context.StringValue("QueryAllCities.Cities["+ i +"].PinYin");
				city.CityCode = context.LongValue("QueryAllCities.Cities["+ i +"].CityCode");
				city.Name = context.StringValue("QueryAllCities.Cities["+ i +"].Name");
				city.Id = context.LongValue("QueryAllCities.Cities["+ i +"].Id");
				city.ParentId = context.LongValue("QueryAllCities.Cities["+ i +"].ParentId");

				queryAllCitiesResponse_cities.Add(city);
			}
			queryAllCitiesResponse.Cities = queryAllCitiesResponse_cities;
        
			return queryAllCitiesResponse;
        }
    }
}
