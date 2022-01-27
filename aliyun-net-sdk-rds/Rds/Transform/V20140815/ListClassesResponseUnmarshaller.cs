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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class ListClassesResponseUnmarshaller
    {
        public static ListClassesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClassesResponse listClassesResponse = new ListClassesResponse();

			listClassesResponse.HttpResponse = _ctx.HttpResponse;
			listClassesResponse.RegionId = _ctx.StringValue("ListClasses.RegionId");
			listClassesResponse.RequestId = _ctx.StringValue("ListClasses.RequestId");

			List<ListClassesResponse.ListClasses_ClassList> listClassesResponse_items = new List<ListClassesResponse.ListClasses_ClassList>();
			for (int i = 0; i < _ctx.Length("ListClasses.Items.Length"); i++) {
				ListClassesResponse.ListClasses_ClassList classList = new ListClassesResponse.ListClasses_ClassList();
				classList.ClassCode = _ctx.StringValue("ListClasses.Items["+ i +"].ClassCode");
				classList.ClassGroup = _ctx.StringValue("ListClasses.Items["+ i +"].ClassGroup");
				classList.Cpu = _ctx.StringValue("ListClasses.Items["+ i +"].Cpu");
				classList.MaxConnections = _ctx.StringValue("ListClasses.Items["+ i +"].MaxConnections");
				classList.MaxIOMBPS = _ctx.StringValue("ListClasses.Items["+ i +"].MaxIOMBPS");
				classList.MaxIOPS = _ctx.StringValue("ListClasses.Items["+ i +"].MaxIOPS");
				classList.MemoryClass = _ctx.StringValue("ListClasses.Items["+ i +"].MemoryClass");
				classList.ReferencePrice = _ctx.StringValue("ListClasses.Items["+ i +"].ReferencePrice");

				listClassesResponse_items.Add(classList);
			}
			listClassesResponse.Items = listClassesResponse_items;
        
			return listClassesResponse;
        }
    }
}
