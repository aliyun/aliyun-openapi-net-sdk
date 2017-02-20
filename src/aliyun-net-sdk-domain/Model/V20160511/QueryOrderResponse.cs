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
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20160511
{
	public class QueryOrderResponse : AcsResponse
	{
	    public string OrderID { get; set; }

	    public string UserID { get; set; }

	    public string Money { get; set; }

	    public string OrderDate { get; set; }

	    public bool? CheckFlag { get; set; }

	    public string CheckDate { get; set; }

	    public bool? ValidFlag { get; set; }

	    public bool? CheckType { get; set; }

	    public List<SubOrderResult> OrderProducts { get; set; }

	    public class SubOrderResult{
	        public string TrackID { get; set; }

	        public string OrderID { get; set; }

	        public string SaleID { get; set; }

	        public string UserID { get; set; }

	        public string ClassID { get; set; }

	        public string ProductName { get; set; }

	        public string RelatedName { get; set; }

	        public string ActionType { get; set; }

	        public int? PeriodUnit { get; set; }

	        public int? PeriodNum { get; set; }

	        public int? Amount { get; set; }

	        public string OrderDate { get; set; }

	        public bool? CheckFlag { get; set; }

	        public string CheckDate { get; set; }

	        public int? BizStatus { get; set; }

	        public string UpdateDate { get; set; }

	        public string DeadDate { get; set; }

	        public bool? ValidFlag { get; set; }

	        public string Money { get; set; }

	        public string ParentSaleID { get; set; }
	    }
	}
}