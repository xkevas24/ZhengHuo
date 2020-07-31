$firewallPort = ""
$firewallRuleName = ""

write-host "Checking for '$firewallRuleName' firewall rule on port '$firewallPort' now...."
if ($(Get-NetFirewallRule –DisplayName $firewallRuleName | Get-NetFirewallPortFilter | Where { $_.LocalPort -eq $firewallPort }))
{
    write-host "Firewall rule for '$firewallRuleName' on port '$firewallPort' already exists, not creating new rule"
}
else
{
    write-host "Firewall rule for '$firewallRuleName' on port '$firewallPort' does not already exist, creating new rule now..."
    New-NetFirewallRule -DisplayName $firewallRuleName -Direction Inbound -Profile Domain,Private,Public -Action Allow -Protocol TCP -LocalPort $firewallPort -RemoteAddress Any
    write-host "Firewall rule for '$firewallRuleName' on port '$firewallPort' created successfully"
}