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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListBusinessUnitsResponseUnmarshaller
    {
        public static ListBusinessUnitsResponse Unmarshall(UnmarshallerContext context)
        {
			ListBusinessUnitsResponse listBusinessUnitsResponse = new ListBusinessUnitsResponse();

			listBusinessUnitsResponse.HttpResponse = context.HttpResponse;
			listBusinessUnitsResponse.PageSize = context.IntegerValue("ListBusinessUnits.PageSize");
			listBusinessUnitsResponse.TotalCount = context.IntegerValue("ListBusinessUnits.TotalCount");
			listBusinessUnitsResponse.PageNumber = context.IntegerValue("ListBusinessUnits.PageNumber");
			listBusinessUnitsResponse.RequestId = context.StringValue("ListBusinessUnits.RequestId");
			listBusinessUnitsResponse.Success = context.BooleanValue("ListBusinessUnits.Success");

			List<ListBusinessUnitsResponse.ListBusinessUnits_BusinessUnitModel> listBusinessUnitsResponse_businessUnits = new List<ListBusinessUnitsResponse.ListBusinessUnits_BusinessUnitModel>();
			for (int i = 0; i < context.Length("ListBusinessUnits.BusinessUnits.Length"); i++) {
				ListBusinessUnitsResponse.ListBusinessUnits_BusinessUnitModel businessUnitModel = new ListBusinessUnitsResponse.ListBusinessUnits_BusinessUnitModel();
				businessUnitModel.BusinessUnitId = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].BusinessUnitId");
				businessUnitModel.CreateDate = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].CreateDate");
				businessUnitModel.PhoneNumber = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].PhoneNumber");
				businessUnitModel.Name = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].Name");
				businessUnitModel.Description = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].Description");
				businessUnitModel.Disable = context.IntegerValue("ListBusinessUnits.BusinessUnits["+ i +"].Disable");
				businessUnitModel.Contact = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].Contact");
				businessUnitModel.UpdateDate = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].UpdateDate");
				businessUnitModel.Code = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].Code");
				businessUnitModel.Address = context.StringValue("ListBusinessUnits.BusinessUnits["+ i +"].Address");

				listBusinessUnitsResponse_businessUnits.Add(businessUnitModel);
			}
			listBusinessUnitsResponse.BusinessUnits = listBusinessUnitsResponse_businessUnits;
        
			return listBusinessUnitsResponse;
        }
    }
}
