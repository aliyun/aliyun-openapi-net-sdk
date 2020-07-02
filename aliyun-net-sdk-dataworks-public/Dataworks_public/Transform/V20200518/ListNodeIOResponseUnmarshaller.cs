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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListNodeIOResponseUnmarshaller
    {
        public static ListNodeIOResponse Unmarshall(UnmarshallerContext context)
        {
			ListNodeIOResponse listNodeIOResponse = new ListNodeIOResponse();

			listNodeIOResponse.HttpResponse = context.HttpResponse;
			listNodeIOResponse.Success = context.BooleanValue("ListNodeIO.Success");
			listNodeIOResponse.ErrorCode = context.StringValue("ListNodeIO.ErrorCode");
			listNodeIOResponse.ErrorMessage = context.StringValue("ListNodeIO.ErrorMessage");
			listNodeIOResponse.HttpStatusCode = context.IntegerValue("ListNodeIO.HttpStatusCode");
			listNodeIOResponse.RequestId = context.StringValue("ListNodeIO.RequestId");

			List<ListNodeIOResponse.ListNodeIO_DataItem> listNodeIOResponse_data = new List<ListNodeIOResponse.ListNodeIO_DataItem>();
			for (int i = 0; i < context.Length("ListNodeIO.Data.Length"); i++) {
				ListNodeIOResponse.ListNodeIO_DataItem dataItem = new ListNodeIOResponse.ListNodeIO_DataItem();
				dataItem.TableName = context.StringValue("ListNodeIO.Data["+ i +"].TableName");
				dataItem.Data = context.StringValue("ListNodeIO.Data["+ i +"].Data");

				listNodeIOResponse_data.Add(dataItem);
			}
			listNodeIOResponse.Data = listNodeIOResponse_data;
        
			return listNodeIOResponse;
        }
    }
}
