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
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Domain.Model.V20160511
{
	public class QueryContactResponse : AcsResponse
	{
	    public string CreateDate { get; set; }

	    public string UpdateDate { get; set; }

	    public string CName { get; set; }

	    public string EName { get; set; }

	    public string CCompany { get; set; }

	    public string ECompany { get; set; }

	    public string CCountry { get; set; }

	    public string CProvince { get; set; }

	    public string EProvince { get; set; }

	    public string CCity { get; set; }

	    public string ECity { get; set; }

	    public string CVenu { get; set; }

	    public string EVenu { get; set; }

	    public string Email { get; set; }

	    public string TelArea { get; set; }

	    public string PostalCode { get; set; }

	    public string TelMain { get; set; }

	    public string TelExt { get; set; }

	    public string RegType { get; set; }
	}
}