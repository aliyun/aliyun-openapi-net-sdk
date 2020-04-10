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
    public class ListExpressCompanyResponseUnmarshaller
    {
        public static ListExpressCompanyResponse Unmarshall(UnmarshallerContext context)
        {
			ListExpressCompanyResponse listExpressCompanyResponse = new ListExpressCompanyResponse();

			listExpressCompanyResponse.HttpResponse = context.HttpResponse;
			listExpressCompanyResponse.PageSize = context.IntegerValue("ListExpressCompany.PageSize");
			listExpressCompanyResponse.TotalCount = context.IntegerValue("ListExpressCompany.TotalCount");
			listExpressCompanyResponse.PageNumber = context.IntegerValue("ListExpressCompany.PageNumber");
			listExpressCompanyResponse.Success = context.BooleanValue("ListExpressCompany.Success");
			listExpressCompanyResponse.RequestId = context.StringValue("ListExpressCompany.RequestId");

			List<ListExpressCompanyResponse.ListExpressCompany_ExpressCompanyBiz> listExpressCompanyResponse_expressCompanies = new List<ListExpressCompanyResponse.ListExpressCompany_ExpressCompanyBiz>();
			for (int i = 0; i < context.Length("ListExpressCompany.ExpressCompanies.Length"); i++) {
				ListExpressCompanyResponse.ListExpressCompany_ExpressCompanyBiz expressCompanyBiz = new ListExpressCompanyResponse.ListExpressCompany_ExpressCompanyBiz();
				expressCompanyBiz.Disable = context.IntegerValue("ListExpressCompany.ExpressCompanies["+ i +"].Disable");
				expressCompanyBiz.UpdateDate = context.StringValue("ListExpressCompany.ExpressCompanies["+ i +"].UpdateDate");
				expressCompanyBiz.CreateDate = context.StringValue("ListExpressCompany.ExpressCompanies["+ i +"].CreateDate");
				expressCompanyBiz.ExpressCompanyId = context.StringValue("ListExpressCompany.ExpressCompanies["+ i +"].ExpressCompanyId");
				expressCompanyBiz.ExpressCompanyName = context.StringValue("ListExpressCompany.ExpressCompanies["+ i +"].ExpressCompanyName");
				expressCompanyBiz.ExpressCompanyCode = context.StringValue("ListExpressCompany.ExpressCompanies["+ i +"].ExpressCompanyCode");
				expressCompanyBiz.Description = context.StringValue("ListExpressCompany.ExpressCompanies["+ i +"].Description");

				listExpressCompanyResponse_expressCompanies.Add(expressCompanyBiz);
			}
			listExpressCompanyResponse.ExpressCompanies = listExpressCompanyResponse_expressCompanies;
        
			return listExpressCompanyResponse;
        }
    }
}
