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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class ListNamespacesResponseUnmarshaller
    {
        public static ListNamespacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNamespacesResponse listNamespacesResponse = new ListNamespacesResponse();

			listNamespacesResponse.HttpResponse = _ctx.HttpResponse;
			listNamespacesResponse.RequestId = _ctx.StringValue("ListNamespaces.RequestId");
			listNamespacesResponse.Code = _ctx.IntegerValue("ListNamespaces.Code");
			listNamespacesResponse.Success = _ctx.BooleanValue("ListNamespaces.Success");
			listNamespacesResponse.Message = _ctx.StringValue("ListNamespaces.Message");

			ListNamespacesResponse.ListNamespaces_Data data = new ListNamespacesResponse.ListNamespaces_Data();

			List<ListNamespacesResponse.ListNamespaces_Data.ListNamespaces__Namespace> data_namespaces = new List<ListNamespacesResponse.ListNamespaces_Data.ListNamespaces__Namespace>();
			for (int i = 0; i < _ctx.Length("ListNamespaces.Data.Namespaces.Length"); i++) {
				ListNamespacesResponse.ListNamespaces_Data.ListNamespaces__Namespace _namespace = new ListNamespacesResponse.ListNamespaces_Data.ListNamespaces__Namespace();
				_namespace.Name = _ctx.StringValue("ListNamespaces.Data.Namespaces["+ i +"].Name");
				_namespace.UId = _ctx.StringValue("ListNamespaces.Data.Namespaces["+ i +"].UId");
				_namespace.Description = _ctx.StringValue("ListNamespaces.Data.Namespaces["+ i +"].Description");

				data_namespaces.Add(_namespace);
			}
			data.Namespaces = data_namespaces;
			listNamespacesResponse.Data = data;
        
			return listNamespacesResponse;
        }
    }
}
