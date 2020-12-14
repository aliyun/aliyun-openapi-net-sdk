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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListCityMapAoisResponseUnmarshaller
    {
        public static ListCityMapAoisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCityMapAoisResponse listCityMapAoisResponse = new ListCityMapAoisResponse();

			listCityMapAoisResponse.HttpResponse = _ctx.HttpResponse;
			listCityMapAoisResponse.Code = _ctx.StringValue("ListCityMapAois.Code");
			listCityMapAoisResponse.Message = _ctx.StringValue("ListCityMapAois.Message");
			listCityMapAoisResponse.RequestId = _ctx.StringValue("ListCityMapAois.RequestId");
			listCityMapAoisResponse.TotalCount = _ctx.LongValue("ListCityMapAois.TotalCount");

			List<ListCityMapAoisResponse.ListCityMapAois_Datas> listCityMapAoisResponse_data = new List<ListCityMapAoisResponse.ListCityMapAois_Datas>();
			for (int i = 0; i < _ctx.Length("ListCityMapAois.Data.Length"); i++) {
				ListCityMapAoisResponse.ListCityMapAois_Datas datas = new ListCityMapAoisResponse.ListCityMapAois_Datas();
				datas.Id = _ctx.StringValue("ListCityMapAois.Data["+ i +"].Id");
				datas._Value = _ctx.StringValue("ListCityMapAois.Data["+ i +"].Value");

				listCityMapAoisResponse_data.Add(datas);
			}
			listCityMapAoisResponse.Data = listCityMapAoisResponse_data;
        
			return listCityMapAoisResponse;
        }
    }
}
