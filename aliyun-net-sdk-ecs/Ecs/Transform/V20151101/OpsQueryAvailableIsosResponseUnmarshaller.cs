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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsQueryAvailableIsosResponseUnmarshaller
    {
        public static OpsQueryAvailableIsosResponse Unmarshall(UnmarshallerContext context)
        {
			OpsQueryAvailableIsosResponse opsQueryAvailableIsosResponse = new OpsQueryAvailableIsosResponse();

			opsQueryAvailableIsosResponse.HttpResponse = context.HttpResponse;
			opsQueryAvailableIsosResponse.RequestId = context.StringValue("OpsQueryAvailableIsos.RequestId");
			opsQueryAvailableIsosResponse.TotalCount = context.IntegerValue("OpsQueryAvailableIsos.TotalCount");
			opsQueryAvailableIsosResponse.PageNo = context.IntegerValue("OpsQueryAvailableIsos.PageNo");
			opsQueryAvailableIsosResponse.PageSize = context.IntegerValue("OpsQueryAvailableIsos.PageSize");

			List<OpsQueryAvailableIsosResponse.Iso> isos = new List<OpsQueryAvailableIsosResponse.Iso>();
			for (int i = 0; i < context.Length("OpsQueryAvailableIsos.Isos.Length"); i++) {
				OpsQueryAvailableIsosResponse.Iso iso = new OpsQueryAvailableIsosResponse.Iso();
				iso.IsoId = context.StringValue("OpsQueryAvailableIsos.Isos["+ i +"].IsoId");
				iso.IsoName = context.StringValue("OpsQueryAvailableIsos.Isos["+ i +"].IsoName");

				isos.Add(iso);
			}
			opsQueryAvailableIsosResponse.Isos = isos;
        
			return opsQueryAvailableIsosResponse;
        }
    }
}